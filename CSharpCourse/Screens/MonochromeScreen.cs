using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Screens {
    public class MonochromeScreen : ScreenBase
    {
        public override void Show(IScreenImage screenImage) {
            throw new NotImplementedException();
        }

        public override void Show(IScreenImage screenImage, int brightness) {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "Monochrome Screen";
        }
    }
}
