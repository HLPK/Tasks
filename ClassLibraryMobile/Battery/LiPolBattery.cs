using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Battery {
    public class LiPolBattery : BatteryBase{
        public LiPolBattery() {
            
        }

        public LiPolBattery(double capacity) {
            this.Capacity = capacity;
        }

        public override string ToString() {
            return $"{base.ToString()}, Type Li-pol";
        }
    }
}
