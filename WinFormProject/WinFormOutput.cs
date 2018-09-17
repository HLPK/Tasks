using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpCourse;

namespace WinFormProject {
    public class WinFormOutput : IOutput
    {
        public TextBox tb;

        public WinFormOutput(TextBox tb) {
            this.tb = tb;
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string text)
        {
            tb.AppendText(text);
        }
    }
}
