using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Battery {
    public  abstract class BatteryBase {
        public double Capacity { get; set; }

        public override string ToString()
        {
            return $"Battery: capacity {Capacity} mAh";
        }
    }
}
