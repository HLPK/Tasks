using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Battery {
    public class NiMHBattery : BatteryBase {

        public NiMHBattery() {

        }

        public NiMHBattery(double capacity) {
            this.Capacity = capacity;
        }

        public override string ToString() {
            return $"{base.ToString()}, Type Ni-MH";
        }
    }
}
