using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.AddDictionary {
    public class OxfordDict : ITranslate {
        private IOutput Output;

        public OxfordDict(IOutput output) {
            Output = output;
        }
        public void Translate(object data)
        {
            Output.WriteLine("Oxford dictionary is translating");
        }

        public override string ToString() {
            return "Oxford dictionary";
        }
    }
}
