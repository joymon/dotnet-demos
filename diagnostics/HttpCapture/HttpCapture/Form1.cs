using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace HttpCapture
{
    public partial class Form1 : Form
    {
        private TextBoxTraceListener _textBoxListener;

        public Form1()
        {
            InitializeComponent();
        }

        private async void MakeHttpCallbutton_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string s = await wc.DownloadStringTaskAsync(@"https://api.pi.delivery/v1/pi?start=0&numberOfDigits=5");
            MessageBox.Show($"Downloaded using WebClient - {s}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            HttpListener list = new HttpListener();
            DiagnosticListener.AllListeners.Subscribe(list);
            _textBoxListener = new TextBoxTraceListener(LogstextBox);
            Trace.Listeners.Add(_textBoxListener);
        }

        private async void MakeHttpCallUsingHttpClientbutton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string s = await client.GetStringAsync(@"https://api.pi.delivery/v1/pi?start=0&numberOfDigits=6");
            MessageBox.Show($"Downloaded using HttpClient - {s}");
        }
    }
}
