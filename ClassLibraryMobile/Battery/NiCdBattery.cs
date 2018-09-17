using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Battery {
    public class NiCdBattery : BatteryBase {
        public NiCdBattery() {

        }

        public NiCdBattery(double capacity) {
            this.Capacity = capacity;
        }

        public override string ToString() {
            return $"{base.ToString()}, Type Ni-cd";
        }
    }
}
