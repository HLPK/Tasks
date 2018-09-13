using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Screens {
    public class OLEDScreen : ColorfulScreen {
        public OLEDScreen() {
            
        }

        public OLEDScreen(float size) {
            this.Size = size;
        }

        public OLEDScreen(float size, Dimensions pixels) {
            this.Size = size;
            this.Pixels = pixels;
        }

        public override void Show(IScreenImage image) {
        }

        public override string ToString()
        {
            return $"{base.ToString()}: OLED {base.GetScreenParameters(this.Size,this.Pixels)}";
        }
    }
}
