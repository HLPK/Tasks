using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMobile;

namespace SMSSimulation {
    public class SMSProvider
    {

        public delegate void SMSReceivedDelegate(string message);

        public event SMSReceivedDelegate SMSReceived;

        public delegate void SMSMessageReceivedDelegate(Message message);

        public event SMSMessageReceivedDelegate SMSMessageReceived;

        public SMSProvider() { }

        private void RaiseSMSReceivedEvent(string message) {
            SMSReceived?.Invoke(message);
        }

        private void RaiseSMSReceivedEvent(Message message) {
            SMSMessageReceived?.Invoke(message);
        }

        public void GetSms(string message) {
            RaiseSMSReceivedEvent(message);
        }

        public void GetSms(Message message) {
            RaiseSMSReceivedEvent(message);
        }
    }
}
