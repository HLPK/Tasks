using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse;

namespace UnitTestMobile {
    public class FakeIOutput : IOutput
    {
        public string fakeString;

        public FakeIOutput() {
            
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string text)
        {
            fakeString = text;
        }
    }
}
