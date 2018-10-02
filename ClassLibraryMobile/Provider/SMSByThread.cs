using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMSSimulation;
using System.Threading;

namespace ClassLibraryMobile.Provider {
    public class SMSByThread : SMSProvider
    {
        public Thread myProvider;
        private Func<string, string> Fm;

        public SMSByThread(Storage store, Func<string, string> fm)
        {
           Fm = fm;
           myProvider = new Thread(new ThreadStart(GenerateMessages));
           myProvider.IsBackground = true;
           myProvider.Start();

           this.SMSMessageReceived += (message) => store.AddMessage(message);
           this.SMSMessageSent += (message) => store.AddMessage(message);
        }

        public override void GenerateMessages() {
            while (true)
            {
                base.SendSms(new Message(Fm($"Message #{++iCountSend} sent!"), false));
                Thread.Sleep(1000);
                base.SendSms(new Message(Fm($"Message #{++iCountReceive} received!"), false));
                Thread.Sleep(1000);
            }
        }

        public override void StopSubProvider()
        {
            myProvider.Abort();
        }

        


    }
}
