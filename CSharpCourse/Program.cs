using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile mobile = new SimCorpMobile();
            Console.WriteLine(  mobile.GetDescription());
            Console.ReadKey();
        }
    }
}
