using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMobile;
using System.Threading;

namespace SMSSimulation {
    public class SMSProvider
    {

        public delegate void SMSReceivedDelegate(string message);
        public event SMSReceivedDelegate SMSReceived;

        public delegate void SMSMessageReceivedDelegate(Message message);
        public event SMSMessageReceivedDelegate SMSMessageReceived;

        public delegate void SMSMessageSentDelegate(Message message);
        public event SMSMessageSentDelegate SMSMessageSent;

        public static int iCountSend=0,iCountReceive=0;

        public SMSProvider() { }

        private void RaiseSMSReceivedEvent(string message) {
            SMSReceived?.Invoke(message);
        }

        private void RaiseSMSReceivedEvent(Message message) {
            SMSMessageReceived?.Invoke(message);
        }

        private void RaiseSMSSentEvent(Message message) {
            SMSMessageSent?.Invoke(message);
        }

        public void GetSms(string message) {
            RaiseSMSReceivedEvent(message);
        }

        public void GetSms(Message message) {
            RaiseSMSReceivedEvent(message);
        }

        public void SendSms(Message message) {
            RaiseSMSSentEvent(message);
        }

        public virtual void GenerateMessages() {}

        public virtual void StopSubProvider() {}

    }
}
