using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMSSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSimulationTests {
    [TestClass()]
    public class RaiseEventTests {
        [TestMethod()]
        public void RaiseEventTest() {
            // Arrange
            MobileClassTest testMobile = new MobileClassTest();
            string message = "Message #1 received!";
            bool raisedEvent = false;

            // Act
            testMobile.SmsProvider.SMSReceived += (msg) => { raisedEvent = true; };
            testMobile.SmsProvider.GetSms(message);

            // Assert
            Assert.IsTrue(raisedEvent);
        }
    }
}