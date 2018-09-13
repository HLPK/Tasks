using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }

        private void Show(IScreenImage image) {
            Screen.Show(image);
        }

        public string GetDescription() {
            var descrioptionBuilder = new StringBuilder();
            descrioptionBuilder.Append($"Screen Type: {Screen.ToString()}");
            return descrioptionBuilder.ToString();
        }

        
    }
}
