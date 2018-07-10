using System;
using System.Diagnostics;

namespace HttpCapture
{
    class DiagnosticObserver : IObserver<DiagnosticListener>
    {
        void IObserver<DiagnosticListener>.OnCompleted()
        {
        }

        void IObserver<DiagnosticListener>.OnError(Exception error)
        {
        }

        void IObserver<DiagnosticListener>.OnNext(DiagnosticListener value)
        {
            if (value.Name.Contains("System.Net.Http"))
            {
                value.Subscribe(new HttpObserver());
            }
        }
    }
}
