using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.Screens;

namespace CSharpCourse
{
    public class SimCorpMobile : Mobile {

        //        public override ScreenBase Screen {get { return vOLEDScreen; } }
        //        private readonly OLEDScreen vOLEDScreen = new OLEDScreen(size: 5, pixels: new Dimensions(1280,800));
        public override int ID { get; set; }

        public override ScreenBase Screen { get; set; }

        public override KeyBoardBase Keyboard { get; set; }

        public SimCorpMobile(int id, ScreenBase screen, KeyBoardBase keyboard) {
            this.ID = id;
            this.Screen = screen;
            this.Keyboard = keyboard;
        }
    }
}
