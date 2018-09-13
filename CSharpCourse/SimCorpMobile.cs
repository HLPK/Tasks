using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public class SimCorpMobile : Mobile
    {
       
        public override ScreenBase Screen {get { return vOLEDScreen; } }
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen(size: 5, pixels: new Dimensions(1280,800));



    }
}
