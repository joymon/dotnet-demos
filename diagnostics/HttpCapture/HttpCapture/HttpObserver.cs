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
            //Do nothing
        }

        void IObserver<KeyValuePair<string, object>>.OnError(Exception error)
        {
            //Do nothing
        }

        void IObserver<KeyValuePair<string, object>>.OnNext(KeyValuePair<string, object> value)
        {
            // This function triggered for all events in the "System.Net.Http" area. Filter based on use case.
            if (value.Key.Equals("System.Net.Http.Desktop.HttpRequestOut.Start"))
            {
                HttpWebRequest req = value.Value.GetType().GetProperty("Request").GetValue(value.Value) as HttpWebRequest;
                if (req != null)
                {
                    Trace.WriteLine($"Http outgoing intercepted - Destination {req.Address}");
                }
            }
        }
    }
}
