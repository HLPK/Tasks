using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMobile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactsTests {
    [TestClass()]
    public class EqualsTest {
        [TestMethod()]
        public void CompareTest() {

            //Arrange//Act
            DateTime dt = DateTime.Now;
            Call newCall1 = new Call(new Contact("Olya", "+380997776655"), "+380997776655", dt, CallDirections.outcoming, 1.0);
            Call newCall2 = new Call(new Contact("Olya", "+380997776655"), "+380997776655", dt, CallDirections.outcoming, 2.2);

            //Assert
            Assert.AreEqual(newCall1, newCall2);
        }
    }
}
