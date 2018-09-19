using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMSSimulation;

namespace SMSSimulationTests {
    public class MobileClassTest
    {
        public SMSProvider SmsProvider;

        public MobileClassTest()
        {
            SmsProvider = new SMSProvider();
        }
    }
}
