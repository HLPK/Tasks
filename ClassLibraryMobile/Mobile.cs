﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.Battery;
using CSharpCourse.Screens;

namespace CSharpCourse
{
    public abstract class Mobile
    {
        public abstract int ID { get; set; }
        public abstract ScreenBase Screen { get; set; }
        public abstract KeyBoardBase Keyboard { get; set; }
        public abstract BatteryBase Battery { get; }
        public abstract SimCard SimCard { get; }
        public abstract Dynamic Dynamic { get; }
        public abstract Microphone Microphone { get; }

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

        private string GetDescription(BatteryBase battery) {
            var descrioptionBuilder = new StringBuilder();
            descrioptionBuilder.Append($"Battery: {battery.ToString()}");
            return descrioptionBuilder.ToString();
        }

        private string GetDescription(SimCard simCard) {
            var descrioptionBuilder = new StringBuilder();
            descrioptionBuilder.Append($"SimCard: {simCard.ToString()}");
            return descrioptionBuilder.ToString();
        }

        private string GetDescription(Dynamic dDynamic) {
            var descrioptionBuilder = new StringBuilder();
            descrioptionBuilder.Append($"Dynamic: {dDynamic.ToString()}");
            return descrioptionBuilder.ToString();
        }

        private string GetDescription(Microphone mic) {
            var descrioptionBuilder = new StringBuilder();
            descrioptionBuilder.Append($"Microphone: {mic.ToString()}");
            return descrioptionBuilder.ToString();
        }

        public void ShowDescription() {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine(  GetDescription(Screen));
            Console.WriteLine(  GetDescription(Keyboard));
            Console.WriteLine(  GetDescription(Battery));
            Console.WriteLine(  GetDescription(SimCard));
            Console.WriteLine(  GetDescription(Dynamic));
            Console.WriteLine(  GetDescription(Microphone));
            Console.WriteLine(  );
        }
        
    }
}