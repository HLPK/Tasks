using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.AddDictionary;
using CSharpCourse.Factory;
using CSharpCourse.KeyBoards;
using CSharpCourse.Screens;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit1");
            SimCorpMobile mobile1 = new SimCorpMobile( id: 1, screen: new OLEDScreen(size: 5, pixels: new Dimensions(1280, 800)), keyboard: new KeyBoardGBoard(layout: Layouts.English, theme: Themes.FeatherLightRed) );
            mobile1.ShowDescription();

            SimCorpMobile mobile2 = new SimCorpMobile(id: 2, screen: new RetinaScreen(), keyboard: new KeyBoardGBoard(layout: Layouts.Ukrainian, theme: Themes.FeatherDarkRed));
            mobile2.ShowDescription();
            
            Console.WriteLine();

            ///////////////////////////////////////////////////
            Console.WriteLine("Unit2");
            IOutput output = new ConsoleOutput();
            FactoryDict factory = new FactoryDict(output: ref output);

            output.WriteLine("Select Dictionary (specify index)");
            factory.Print();

            int choise_int = 0;
            if (MakeChoise(out choise_int))
            {
                int ind = choise_int - 1;
                ITranslate choise_item = factory.GetFactoryItem(ref ind);
                output.WriteLine($"{choise_item.ToString()} selected");
                output.WriteLine(" Set Dictionary to Mobile...");
                output.WriteLine(" Start translating...");
                choise_item.Translate("test");
            }




            ///////////////////////////////////////////////////
            Console.ReadKey();
        }

        static bool MakeChoise(out int choise_int)
        {
            string choise;
            int ch_int = 0;
            bool parse_input = true;
            bool doChoise = false, madeChoise = false;

            while (doChoise == false)
            {
                try {
                    choise = Console.ReadLine();
                    parse_input = Int32.TryParse(choise, out ch_int);
                    if (parse_input == false) {
                        throw new Exception("It is not a numeral key");
                    } else
                    {
                        if (ch_int < 1 || ch_int > 4)
                            throw new Exception("Index is out of range");
                        else madeChoise = true;
                    }
                } catch (Exception ex) {
                    Console.WriteLine("Error " + ex.Message);
                }
                if (madeChoise)
                {
                    doChoise = true;
                }
                else
                {
                    Console.WriteLine("Continue? (Y)");
                    if (Console.ReadLine() != "Y")
                    {
                        doChoise = true;
                    }
                }
            }
            choise_int = ch_int;
            return madeChoise;
        }
    }
}
