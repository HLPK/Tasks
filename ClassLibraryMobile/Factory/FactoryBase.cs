using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.AddDictionary;

namespace CSharpCourse.Factory {
    public abstract class FactoryBase : IEnumerable
    {
        public IOutput Output { get; set; }
        public abstract ITranslate[] Factory { get; set; }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public void Print()
        {
            int i = 1;
            foreach (var item in Factory)
            {
                Output.WriteLine($"{i++.ToString()} - {item.ToString()}");
            }
        }

        public ITranslate GetFactoryItem(int ind)
        {
            return Factory[ind];
        }
    }
}
