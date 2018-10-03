using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobile {
    public class Contact {
        public string Name { get; set; }
        public List<string> Phones { get; set; }

        public Contact()
        {
        }

        public Contact(string name, string phone)
        {
            Name = name;
            Phones = new List<string>();
            Phones.Add(phone);
        }

        public Contact(string name, List<string> phones) {
            Name = name;
            Phones = new List<string>();
            foreach (var item in phones)
                Phones.Add(item);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;
            else {
                Contact c = (Contact)obj;
                return (Name == c.Name);
            }
        }
    }
}
