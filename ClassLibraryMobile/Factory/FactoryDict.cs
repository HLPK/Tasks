using CSharpCourse.AddDictionary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Factory {
    public class FactoryDict : FactoryBase{

        public override ITranslate[] Factory { get; set; }

        public FactoryDict(IOutput output)
        {
            Output = output;
            Factory = new ITranslate[4];
            Factory[0] = new ABBYYDict(output);
            Factory[1] = new OxfordDict(output);
            Factory[2] = new PromptDict(output);
            Factory[3] = new UnknownDict(output);
        }
    }
}
