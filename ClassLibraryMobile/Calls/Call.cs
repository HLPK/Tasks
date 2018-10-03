using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobile {
    public enum CallDirections
    {
        incoming,
        outcoming
    }

   
    public class Call : IComparable<Call>, ICloneable {
        public Contact Cont { get; set; }
        public string Phone { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime CallTimeHistory { get; set; }
        public CallDirections Direction { get; set; }
        public double Duration { get; set; }
        public int Num { get; set; }

        public Call()
        {
                
        }

        public Call(Contact cont, string phone, DateTime callTime, CallDirections direction, double duration) {
            Cont = cont;
            Phone = phone;
            CallTime = callTime;
            CallTimeHistory = callTime;
            Direction = direction;
            Duration = duration;
            Num = 1;
        }

        public Call(Contact cont, string phone, CallDirections direction, DateTime callTime) {
            Cont = cont;
            Phone = phone;
            Direction = direction;
            CallTime = callTime;
        }

        public int CompareTo(Call other)
        {
            if (this.CallTime > other.CallTime) return 1;
            if (this.CallTime < other.CallTime) return -1;
            else return 0;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;
            else
            {
                Call c = (Call) obj;
                return (Cont.Equals(c.Cont)) && (Phone == c.Phone) && (Direction == c.Direction) && (Math.Abs((c.CallTime - CallTime).TotalSeconds) < 1); 
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool EqualsLast(Call c)
        {
             return (Cont.Equals(c.Cont)) && (Phone == c.Phone) && (Direction == c.Direction);
        }
    }
}
