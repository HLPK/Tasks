using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactsWinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsWinForm.Tests {
    [TestClass()]
    public class SortingTests {
        private List<Call> CreateRepo()
        {
            Contact conactVasya = new Contact("Vasya", "+380986543211");
            List<Call> list = new List<Call>();
            list.Add(new Call(conactVasya, "+380986543211",DateTime.Today.AddDays(-2),CallDirections.incoming));
            list.Add(new Call(conactVasya, "+380986543211", DateTime.Now, CallDirections.incoming));
            list.Add(new Call(new Contact("Petya", "+380661234567"), "+380661234567", DateTime.Today.AddDays(-1), CallDirections.outcoming));
            list.Sort();
            return list;
        }

        [TestMethod()]
        public void AddingSortingTest()
        {
            //Arrange
            List<Call> calls = CreateRepo();
            Call newCall = new Call(new Contact("Olya", "+380997776655"), "+380997776655", DateTime.Now, CallDirections.outcoming);

            //Act
            calls.Add(newCall);
            calls.Sort();

            //Assert
            //Assert.AreEqual(newCall,calls[0]);
            Assert.IsTrue(calls[0].CompareTo(newCall) == 0);
        }

        [TestMethod()]
        public void DeletingSortingTest() {
            //Arrange
            List<Call> calls = CreateRepo();

            //Act
            calls.RemoveAt(1);
            calls.Sort();

            //Assert
            Assert.IsTrue(calls[0].CompareTo(calls[1]) == -1);
        }
    }
}