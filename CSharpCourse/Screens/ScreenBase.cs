using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Screens {
    public abstract  class ScreenBase
    {
        public float Size { get; set; }
        public Dimensions Pixels { get; set; }

        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);

        public string GetScreenParameters(float size, Dimensions dimensions) {
            return $"Screen parameters: {dimensions.ToString()} {size.ToString()}\" ";
        }
    }
}
