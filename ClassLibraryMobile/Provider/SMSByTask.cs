using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMSSimulation;
using System.Threading;

namespace ClassLibraryMobile.Provider {
    public class SMSByTask : SMSProvider {

        public Task myProvider;
        private Func<string, string> Fm;

        private static CancellationTokenSource ts;
        private CancellationToken ct;

        public SMSByTask(Storage store, Func<string, string> fm) {
            Fm = fm;
            ts = new CancellationTokenSource();
            ct = ts.Token;
            myProvider = Task.Factory.StartNew(GenerateMessages,ct);

            this.SMSMessageReceived += (message) => store.AddMessage(message);
            this.SMSMessageSent += (message) => store.AddMessage(message);
        }

        public override void GenerateMessages() {
            while (true) {
                if (ct.IsCancellationRequested) break;
                base.SendSms(new Message(Fm($"Message #{++iCountSend} sent!"), false));
                Thread.Sleep(2000);
                base.SendSms(new Message(Fm($"Message #{++iCountReceive} received!"), false));
                Thread.Sleep(2000);
            }
        }

        public override void StopSubProvider() {
            ts.Cancel();
        }

    }
}
