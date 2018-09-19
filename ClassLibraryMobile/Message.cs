using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobile
{
    public class Message {
        public List<string> MessageUsers = new List<string>() { "+380394561245", "+380989877445", "+380664110000", "+38095987654", "+380661000000" };
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; set; }

        private Random rnd = new Random();
        public Message(string text) {
            Text = text;
            User = MessageUsers[rnd.Next(0,4)];
        }


    }
}
