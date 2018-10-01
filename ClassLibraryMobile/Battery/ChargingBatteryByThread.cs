using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.Battery;
using System.Threading;

namespace ClassLibraryMobile.Battery {
    public class ChargingBatteryByThread : ChargingBattery
    {
        private Thread chargeThread;
        private Thread dischargeThread;

        public ChargingBatteryByThread(BatteryBase battery) : base(battery)
        {
            dischargeThread = new Thread(new ThreadStart(Discharging));
            dischargeThread.IsBackground = true;
            dischargeThread.Start();

        }

        public ChargingBatteryByThread()
        {
        }

        public override void Charge()
        {
            chargeThread = new Thread(new ThreadStart(Charging));
            chargeThread.IsBackground = true;
            chargeThread.Start();
        }


        public override void StopCharge()
        {
            chargeThread.Abort();
        }

        public override void StopAll()
        {
            dischargeThread?.Abort();
            chargeThread?.Abort();
        }
    }
}
