using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpCourse.Battery;

namespace ClassLibraryMobile.Battery {
    public abstract class ChargingBattery
    {
        public BatteryBase Battery { get; set; }

        public ChargingBattery(BatteryBase battery)
        {
            Battery = battery;
        }

        public ChargingBattery()
        {
        }

        public abstract void Charge();
        public abstract void StopCharge();
        public abstract void StopAll();

        public void Charging() {
            while (Battery.Charge < 100) {
                lock (Battery) {
                    Battery.Charge++;
                }
                Thread.Sleep(500);
            }
        }

        public void Discharging() {

            while (true) {
                if ((Battery.Charge > 0)) {
                    lock (Battery) {
                        Battery.Charge--;
                    }
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
