using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.AddDictionary {
    public class PromptDict : ITranslate{
        private IOutput Output;

        public PromptDict(IOutput output) {
            Output = output;
        }
        public void Translate(object data)
        {
            Output.WriteLine("Prompt dictionary is translating");
        }

        public override string ToString() {
            return "Prompt dictionary";
        }
    }
}
