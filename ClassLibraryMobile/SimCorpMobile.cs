using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.Battery;
using CSharpCourse.Screens;

namespace CSharpCourse
{
    public class SimCorpMobile : Mobile {

        //        public override ScreenBase Screen {get { return vOLEDScreen; } }
        //        private readonly OLEDScreen vOLEDScreen = new OLEDScreen(size: 5, pixels: new Dimensions(1280,800));
        public override int ID { get; set; }

        public override ScreenBase Screen { get; set; }

        public override KeyBoardBase Keyboard { get; set; }

        public override BatteryBase Battery { get { return battery; } }
        private readonly LiIonBattery battery = new LiIonBattery(capacity: 3000);

        public override SimCard SimCard {get { return simcard; } }
        private readonly SimCard simcard = new SimCard(SimCardType.MicroSim);

        public override Dynamic Dynamic { get { return scdynamic; } }
        private readonly Dynamic scdynamic= new Dynamic(producer: "HTC", mode: DynamicMode.Speaker, dType: DynamicType.Speaker, location: DynamicLocation.Bottom);

        public override Microphone Microphone { get { return mic; } }
        private readonly Microphone mic = new Microphone(frequencyFrom: 100, frequencyTo: 160, distance: 1.5);

        public SimCorpMobile(int id, ScreenBase screen, KeyBoardBase keyboard) {
            this.ID = id;
            this.Screen = screen;
            this.Keyboard = keyboard;
        }
    }
}
