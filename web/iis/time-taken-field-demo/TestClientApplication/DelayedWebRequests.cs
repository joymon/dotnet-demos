using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SlowResponseDemo
{
    class DelayedWebRequests
    {
        static void Test(string[] args)
        {
            string url = "http://localhost/httpcaching/8mbtest.json";
            int delayInMS = 100;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //var responseString = GetUsingHttpRequest(url, delayInMS);
            //var responseString = GetUsingHttpClient(url, delayInMS);
            var responseString = GetUsingTCPSockets(url, delayInMS);
            sw.Stop();
            Console.WriteLine($"Read {responseString.Length} sized from {url} in  {sw.Elapsed.TotalSeconds} seconds ");
            Console.ReadLine();
        }
        private static string GetUsingTCPSockets(string url, int delayInMS)
        {
            Uri urlInst = new Uri(url);

            var request = $"GET {urlInst.PathAndQuery} HTTP/1.1\r\n" +
                                $"Host: {urlInst.Host}\r\n" +
                                "Accept-Language: en-US,en;q=0.9\r\n" +
                                "Accept: application/json, text/plain, */*\r\n" +
                                "Connection: close\r\n" +
                                "Content-Length: 0\r\n" + "\r\n";
            string page = "Default HTML page on " + urlInst.Host + ":\r\n";
            Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
            using (Socket s = ConnectSocket(urlInst.Host, urlInst.Port))
            {

                if (s == null)
                    return ("Connection failed");

                // Send request to the server.
                s.Send(bytesSent, bytesSent.Length, 0);

                // Receive the server home page content.
                int bytes = 0;

                Byte[] bytesReceived = new Byte[131072];
                //The main point is to reduce the buffer to simulate the delay in network transfer
                s.ReceiveBufferSize = bytesReceived.Length > 65536 ? 65536: bytesReceived.Length;
                // The following will block until the page is transmitted.
                do
                {
                    bytes =  s.Receive(bytesReceived, bytesReceived.Length, 0);
                    page = page + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                    Thread.Sleep(delayInMS);
                }
                while (bytes > 0);
            }

            return page;
        }
        private static Socket ConnectSocket(string server, int port)
        {
            Socket s = null;
            IPHostEntry hostEntry = null;

            // Get host related information.
            hostEntry = Dns.GetHostEntry(server);

            // Loop through the AddressList to obtain the supported AddressFamily. This is to avoid
            // an exception that occurs when the host IP Address is not compatible with the address family
            // (typical in the IPv6 case).
            foreach (IPAddress address in hostEntry.AddressList)
            {
                IPEndPoint ipe = new IPEndPoint(address, port);
                Socket tempSocket =
                    new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                tempSocket.Connect(ipe);

                if (tempSocket.Connected)
                {
                    s = tempSocket;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return s;
        }
        private static string GetUsingHttpClient(string url, int delayInMS)

        {
            HttpClient client = new HttpClient();
            Task<Stream> tsk = client.GetStreamAsync(url);
            string responseString = string.Empty;
            int responseByte;
            while ((responseByte = tsk.Result.ReadByte()) != -1)
            {
                responseString += Convert.ToChar(responseByte);
                Thread.Sleep(delayInMS);
            }

            return responseString;
        }
        private static string GetUsingHttpRequest(string url, int delayInMS)
        {
            HttpWebRequest req = HttpWebRequest.CreateHttp(url);
            var response = req.GetResponse();
            var stream = response.GetResponseStream();

            string responseString = string.Empty;
            int responseByte;
            while ((responseByte = stream.ReadByte()) != -1)
            {
                responseString += Convert.ToChar(responseByte);
                Thread.Sleep(delayInMS);
            }

            return responseString;
        }
    }
}
