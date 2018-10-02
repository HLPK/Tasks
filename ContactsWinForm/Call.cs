using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsWinForm {
    public enum CallDirections
    {
        incoming,
        outcoming
    }
    public class Call : IComparable<Call> {
        public Contact Cont { get; set; }
        public string Phone { get; set; }
        public DateTime CallTime { get; set; }
        public CallDirections Direction { get; set; }

        public Call()
        {
                
        }

        public Call(Contact cont, string phone, DateTime callTime, CallDirections direction) {
            Cont = cont;
            Phone = phone;
            CallTime = callTime;
            Direction = direction;
        }

        public int CompareTo(Call other)
        {
            if (this.CallTime > other.CallTime) return -1;
            if (this.CallTime < other.CallTime) return 1;
            else return 0;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;
            else
            {
                Call c = (Call) obj;
                return (Cont.Equals(c.Cont)) && (Phone == c.Phone) && (CallTime == c.CallTime) && (Direction == c.Direction); 
            }
        }
    }
}
