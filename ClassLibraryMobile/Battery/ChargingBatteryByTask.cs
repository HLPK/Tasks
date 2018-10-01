using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Battery;

namespace ClassLibraryMobile.Battery {
    public class ChargingBatteryByTask : ChargingBattery {

        private Task chargeTask;
        private Task dischargeTask;

        private CancellationTokenSource ts_charge,ts_discharge;
        private CancellationToken ct_charge,ct_discharge;

        public ChargingBatteryByTask(BatteryBase battery) : base(battery) {
            ts_discharge = new CancellationTokenSource();
            ct_discharge = ts_discharge.Token;
            dischargeTask = Task.Factory.StartNew(Discharging, ct_discharge);
        }

        public ChargingBatteryByTask()
        {
        }

        public override void Charge()
        {
            ts_charge = new CancellationTokenSource();
            ct_charge = ts_discharge.Token;
            chargeTask = Task.Factory.StartNew(Charging, ct_charge);
        }


        public override void StopCharge()
        {
            ts_discharge.Cancel();
        }

        public override void StopAll()
        {
            ts_discharge?.Cancel();
            ts_charge?.Cancel();
        }

       
    }
}
