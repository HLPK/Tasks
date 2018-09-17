using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Battery {
    public class LiIonBattery : BatteryBase {
        public LiIonBattery() {
            this.Capacity = 1000;
        }

        public LiIonBattery(double capacity) {
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Type Li-ion";
        }
    }
}
