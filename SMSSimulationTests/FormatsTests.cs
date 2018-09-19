using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMSSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSimulation.Tests {
    [TestClass()]
    public class FormatsTests {
        [TestMethod()]
        public void FormatWithTimeTest() {
            // Arrange
            Formats formats = new Formats();
            // Act
            string expectedString = $"[{DateTime.Now}] Message #1 received!";

            //Assert;
            Assert.AreEqual(expectedString,formats.FormatWithTime("Message #1 received!"));
        }

        [TestMethod()]
        public void FormatNone() {
            // Arrange
            Formats formats = new Formats();
            // Act
            string expectedString = "Message #1 received!";

            //Assert;
            Assert.AreEqual(expectedString, formats.FormatNone("Message #1 received!"));
        }

        [TestMethod()]
        public void FormatWithTimeEnd() {
            // Arrange
            Formats formats = new Formats();
            // Act
            string expectedString = $"Message #1 received! [{DateTime.Now}]";

            //Assert;
            Assert.AreEqual(expectedString, formats.FormatWithTimeEnd("Message #1 received!"));
        }

        [TestMethod()]
        public void FormatCustom() {
            // Arrange
            Formats formats = new Formats();
            // Act
            string expectedString = "[My format] Message #1 received!";

            //Assert;
            Assert.AreEqual(expectedString, formats.FormatCustom("Message #1 received!"));
        }

        [TestMethod()]
        public void FormatLowerCase() {
            // Arrange
            Formats formats = new Formats();
            // Act
            string expectedString = "message #1 received!";

            //Assert;
            Assert.AreEqual(expectedString, formats.FormatLowerCase("Message #1 received!"));
        }

        [TestMethod()]
        public void FormatUpperCase() {
            // Arrange
            Formats formats = new Formats();
            // Act
            string expectedString = $"MESSAGE #1 RECEIVED!";

            //Assert;
            Assert.AreEqual(expectedString, formats.FormatUpperCase("Message #1 received!"));
        }
    }
}