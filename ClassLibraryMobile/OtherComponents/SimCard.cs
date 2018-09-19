using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse {
    public enum SimCardType {
        Sim,
        MiniSim,
        MicroSim,
        NanoSim
    }

    public class SimCard {
        public SimCardType ScType { get; set; }

        public SimCard() 
        {
            
        }

        public SimCard(SimCardType scType) {
            ScType = scType;
        }

        public override string ToString()
        {
            return $" Simcard type {ScType}";
        }
    }
}
