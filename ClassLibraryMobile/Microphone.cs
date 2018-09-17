using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse {
    public class Microphone {
        public float FrequencyFrom { get; set; }
        public float FrequencyTo { get; set; }
        public double Distance { get; set; }

        public Microphone()
        {
            
        }

        public Microphone(float frequencyFrom, float frequencyTo, double distance) {
            FrequencyFrom = frequencyFrom;
            FrequencyTo = frequencyTo;
            Distance = distance;
        }

        public override string ToString()
        {
            return $"Microphone: frequency {FrequencyFrom} - {FrequencyTo}, distance {Distance} m.";
        }
    }
}
