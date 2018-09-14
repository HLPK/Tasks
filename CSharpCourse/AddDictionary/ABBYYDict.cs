using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.AddDictionary {
    public class ABBYYDict : ITranslate
    {
        private IOutput Output;

        public ABBYYDict(IOutput output) {
            Output = output;
        }

        public void Translate(object data)
        {
            Output.WriteLine($"{nameof(ABBYYDict)} is translating");
        }

        public override string ToString()
        {
            return "ABBYY dictionary";
        }
    }
}
