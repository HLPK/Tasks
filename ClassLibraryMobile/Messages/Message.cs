using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobile
{
    public enum MessageType
    {
        Incoming,
        Outcoming
    }
    public class Message {
        private List<string> MessageUsers = new List<string>() { "+380394561245", "+380989877445", "+380664110000", "+38095987654", "+380661000000" };
        public string User { get; set; }
        public string Text { get; set; }
        public MessageType MsgType { get; set; }
        public DateTime ReceivingTime { get; set; }

        private static Random rnd = new Random();
        public Message(string text) {
            Text = text;
            User = MessageUsers[rnd.Next(0,4)];
            MsgType = MessageType.Incoming;
        }

        public Message(string text, bool incoming) {
            Text = text;
            User = MessageUsers[rnd.Next(0, 4)];
            MsgType = (incoming?MessageType.Incoming:MessageType.Outcoming);
            ReceivingTime = DateTime.Now;
        } 

        public Message(string text,string user, DateTime receivingTime) {
            Text = text;
            User = user;
            ReceivingTime = receivingTime;
            MsgType = MessageType.Incoming;
        }

    }
}
