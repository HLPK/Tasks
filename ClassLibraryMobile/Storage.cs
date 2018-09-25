using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobile {
    public class Storage
    {
        public List<Message> Messages;

        public delegate void MessageHandler();

        public event MessageHandler MessageAdded;
        public event MessageHandler MessageRemoved;

        public Storage()
        {
            Messages = new List<Message>();
        }

        public void AddMessage(Message msg)
        {
            Messages.Add(msg);
            MessageAdded?.Invoke();
        }

        public void RemoveMessage(Message msg)
        {
            Messages.Remove(msg);
            MessageRemoved?.Invoke();
        }
    }
}
