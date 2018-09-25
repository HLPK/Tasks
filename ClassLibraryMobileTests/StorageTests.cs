using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMobile;
using CSharpCourse.KeyBoards;
using CSharpCourse.Screens;


namespace CSharpCourse.Tests {
    [TestClass()]
    public class StorageTests {
        public List<Message> CreateRepository(DateTime dt) {
            List<Message> rez = new List<Message>();
            rez.Add(new Message("Test #1", "+380501002030", dt));
            rez.Add(new Message("Test #2", "+380501002030", dt));
            rez.Add(new Message("Test #3", "+380981002030", dt));
            return rez;
        }

        [TestMethod()]
        public void IncomingMsgTest() {
            // Arrange
            List<Message> repo = new List<Message>();
            Mobile mobile = new SimCorpMobile(12, new RetinaScreen(), new KeyBoardGBoard(layout: Layouts.English, theme: Themes.FeatherDarkBlue));
            DateTime dt = DateTime.Now;

            //Act
            Message msg = new Message("Test #1", "+380501002030", dt);
            mobile.SmsProvider.GetSms(msg);
            repo.Add(msg);

            //Assert
            Assert.IsTrue(repo.Except(mobile.Store.Messages).Count() == 0);
        }

        [TestMethod()]
        public void AddingMsgTest() {
            // Arrange
            List<Message> repo = new List<Message>();
            DateTime dt = DateTime.Now;
            Storage store = new Storage();

            //Act
            Message msg = new Message("Test #1", "+380501002030", dt);
            store.AddMessage(msg);
            repo.Add(msg);

            //Assert
            Assert.IsTrue(repo.Except(store.Messages).Count() == 0);
        }

        [TestMethod()]
        public void RemovingMsgTest() {
            // Arrange
            DateTime dt = DateTime.Now;
            Storage store = new Storage();
            List<Message> repo = new List<Message>();
            repo.Add(new Message("Test #1", "+380501002030", dt));
            repo.Add(new Message("Test #2", "+380501002030", dt));
            repo.Add(new Message("Test #3", "+380981002030", dt));
            foreach (var msg in repo)
                store.Messages.Add(msg);
            
            //Act
            Message rem = repo[0];
            repo.Remove(rem);
            store.RemoveMessage(rem);

            //Assert
            Assert.IsTrue(repo.Except(store.Messages).Count() == 0);
        }
    }
}