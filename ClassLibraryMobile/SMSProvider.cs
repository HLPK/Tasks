using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSimulation {
    public class SMSProvider
    {

        public delegate void SMSReceivedDelegate(string message);

        public event SMSReceivedDelegate SMSReceived;

        public SMSProvider() { }

        private void RaiseSMSReceivedEvent(string message) {
            SMSReceived?.Invoke(message);
        }

        public void GetSms(string message) {
            RaiseSMSReceivedEvent(message);
        }

    }
}
