using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.Factory;

namespace CSharpCourse {
    class ConsoleOutput : IOutput {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

//        public void PrintFactory(FactoryBase factory)
//        {
//            int i = 1;
//            foreach (var item in factory) {
//                WriteLine($"{i++.ToString()} - {item.ToString()}");
//            }
//        }

    }
}
