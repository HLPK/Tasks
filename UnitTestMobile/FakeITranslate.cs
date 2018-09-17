using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse;
using CSharpCourse.AddDictionary;

namespace UnitTestMobile {
    public class FakeITranslate : ITranslate
    {
        private IOutput Output;

        public FakeITranslate(IOutput output) {
            Output = output;
        }

        public void Translate(object data)
        {
            Output.WriteLine($"{nameof(ABBYYDict)} is translating");
        }
    }
}
