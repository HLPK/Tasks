using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse {
    public enum DynamicMode
    {
        Buzzer,
        Speaker,
        BuzzerSpeaker
    }
    public enum DynamicType {
        External,
        Speaker
    }
    public enum DynamicLocation {
        Top,
        Bottom
    }
    public class Dynamic {
        public string Producer { get; set; }
        public DynamicMode Mode { get; set; }
        public DynamicType DType { get; set; }
        public DynamicLocation Location { get; set; }

        public Dynamic()
        {
            Mode = DynamicMode.Speaker;
            DType = DynamicType.Speaker;
            Location = DynamicLocation.Bottom;
        }

        public Dynamic(string producer, DynamicMode mode, DynamicType dType, DynamicLocation location) {
            Producer = producer;
            Mode = mode;
            DType = dType;
            Location = location;
        }

        public override string ToString()
        {
            return $"Dynamic characteristics: {(String.IsNullOrEmpty(Producer)?"":Producer+", ")} mode {Mode} type {DType} location {Location}"; 
        }
    }
}
