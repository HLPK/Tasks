using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.AddDictionary;

namespace CSharpCourse.Factory {
    public abstract class FactoryBase
    {
        public abstract ITranslate[] Factory { get; set; }
        private IOutput output = new ConsoleOutput();

        public void Print()
        {
            int i = 1;    
            foreach (var item in Factory)
            {
                output.WriteLine($"{i++.ToString()} - {item.ToString()}");
            }
        }

        public ITranslate GetFactoryItem(ref int ind)
        {
            return Factory[ind];
        }
    }
}
