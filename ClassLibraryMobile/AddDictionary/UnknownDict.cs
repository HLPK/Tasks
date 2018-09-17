using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.AddDictionary {
    public class UnknownDict : ITranslate {
        private IOutput Output;

        public UnknownDict(IOutput output) {
            Output = output;
        }

        public void Translate(object data)
        {
            Output.WriteLine("Unknown dictionary is translating");
        }

        public override string ToString() {
            return "Unknown dictionary";
        }
    }
}
