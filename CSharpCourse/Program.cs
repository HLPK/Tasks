using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.KeyBoards;
using CSharpCourse.Screens;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile mobile1 = new SimCorpMobile( id: 1, screen: new OLEDScreen(size: 5, pixels: new Dimensions(1280, 800)), keyboard: new KeyBoardGBoard(layout: Layouts.English, theme: Themes.FeatherLightRed) );
            mobile1.ShowDescription();

            SimCorpMobile mobile2 = new SimCorpMobile(id: 2, screen: new RetinaScreen(), keyboard: new KeyBoardGBoard(layout: Layouts.Ukrainian, theme: Themes.FeatherDarkRed));
            mobile2.ShowDescription();

            Console.ReadKey();
        }
    }
}
