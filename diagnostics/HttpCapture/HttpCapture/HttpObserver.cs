using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;

namespace HttpCapture
{
    class HttpObserver : IObserver<KeyValuePair<string, object>>
    {
        void IObserver<KeyValuePair<string, object>>.OnCompleted()
        {
            //throw new NotImplementedException();
        }

        void IObserver<KeyValuePair<string, object>>.OnError(Exception error)
        {
            //throw new NotImplementedException();
        }

        void IObserver<KeyValuePair<string, object>>.OnNext(KeyValuePair<string, object> value)
        {
            if (value.Key.Equals("System.Net.Http.Desktop.HttpRequestOut.Start"))
            {
                HttpWebRequest req = value.Value.GetType().GetProperty("Request").GetValue(value.Value) as HttpWebRequest;
                if (req != null)
                {
                    Trace.WriteLine($"Http outgoing intercepted - Destination {req.Address}");
                }
            }
            //throw new NotImplementedException();
        }
    }
}
