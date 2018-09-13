using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.Screens;

namespace CSharpCourse
{
    public abstract class Mobile
    {
        public abstract int ID { get; set; }
        public abstract ScreenBase Screen { get; set; }
        public abstract KeyBoardBase Keyboard { get; set; }

        private void Show(IScreenImage image) {
            Screen.Show(image);
        }

        public string GetDescription() {
            var descrioptionBuilder = new StringBuilder();
            descrioptionBuilder.Append($"ID: {ID}; ");
            descrioptionBuilder.Append($"Screen Type: {Screen.ToString()}; ");
            descrioptionBuilder.Append($"Keyboard: {Keyboard.ToString()}");
            return descrioptionBuilder.ToString();
        }

        private string GetDescription(ScreenBase screen)
        {
            var descrioptionBuilder = new StringBuilder();
            descrioptionBuilder.Append($"Screen Type: {Screen.ToString()}; ");
            return descrioptionBuilder.ToString();
        }

        private string GetDescription(KeyBoardBase keyBoard) {
            var descrioptionBuilder = new StringBuilder();
            descrioptionBuilder.Append($"Keyboard: {Keyboard.ToString()}");
            return descrioptionBuilder.ToString();
        }

        public void ShowDescription() {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine(  GetDescription(Screen));
            Console.WriteLine(  GetDescription(Keyboard));
            Console.WriteLine(  );
        }
        
    }
}
