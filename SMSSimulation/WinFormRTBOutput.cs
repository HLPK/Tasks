using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpCourse;

namespace SMSSimulation {
    public class WinFormRTBOutput : IOutput
    {
        public RichTextBox rtb;

        public WinFormRTBOutput(RichTextBox rtb) {
            this.rtb = rtb;
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string text)
        {
            rtb.AppendText($"{text}{ Environment.NewLine}");
        }
    }
}
