using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryMobile.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMobile.Messages.Tests {
    [TestClass()]
    public class FilterTests {
        public List<Message> CreateRepository(DateTime dt)
        {
            List<Message> rez = new List<Message>();
            rez.Add(new Message("Test #1","+380501002030", dt));
            rez.Add(new Message("Test #2","+380501002030", dt));
            rez.Add(new Message("Test #3","+380981002030", dt));
            return rez;
        }
        [TestMethod()]
        public void FilterTestUser() {
            // Arrange
            List<Message> rez = CreateRepository(DateTime.Now);
            Filter filter = new Filter(subscriber: "+380501002030", messagePattern: "", dateFrom: DateTime.Now, dateTo: DateTime.Now, isSubscriber: true, isMessagePattern: false, isPeriod: false, isOr: true);

            // Act
            var filterByUser = rez.Where(m => m.User == "+380501002030").ToList();

            //Assert
            Assert.IsTrue(filterByUser.Except(filter.GetFilteredList(rez)).Count() == 0);
        }

        [TestMethod()]
        public void FilterTestMsg() {
            // Arrange
            List<Message> rez = CreateRepository(DateTime.Now);
            Filter filter = new Filter(subscriber: "", messagePattern: "est", dateFrom: DateTime.Now, dateTo: DateTime.Now, isSubscriber: false, isMessagePattern: true, isPeriod: false, isOr: true);

            // Act
            var filterByUser = rez.Where(m => m.Text.Contains("est")).ToList();

            //Assert
            Assert.IsTrue(filterByUser.Except(filter.GetFilteredList(rez)).Count() == 0);
        }

        [TestMethod()]
        public void FilterTestPeriod() {
            // Arrange
            DateTime dateTime = DateTime.Now;
            List<Message> rez = CreateRepository(dateTime);
            Filter filter = new Filter(subscriber: "", messagePattern: "", dateFrom: dateTime, dateTo: dateTime, isSubscriber: false, isMessagePattern: false, isPeriod: true, isOr: true);

            // Act
            var filterByUser = rez.Where(m => m.ReceivingTime >= dateTime && m.ReceivingTime <= dateTime).ToList();

            //Assert
            Assert.IsTrue(filterByUser.Except(filter.GetFilteredList(rez)).Count() == 0);
        }

        [TestMethod()]
        public void FilterTestUserAndMsgAndPeriod() {
            // Arrange
            DateTime dateTime = DateTime.Now;
            List<Message> rez = CreateRepository(dateTime);
            Filter filter = new Filter(subscriber: "+380501002030", messagePattern: "est", dateFrom: dateTime, dateTo: dateTime, isSubscriber: true, isMessagePattern: true, isPeriod: true, isOr: false);

            // Act
            var filterByUser = rez.Where(m => m.User == "+380501002030" && m.Text.Contains("est") && m.ReceivingTime >= dateTime && m.ReceivingTime <= dateTime).ToList();

            //Assert
            Assert.IsTrue(filterByUser.Except(filter.GetFilteredList(rez)).Count() == 0);
        }


        [TestMethod()]
        public void FilterTestUserOrMsgOrPeriod() {
            // Arrange
            DateTime dateTime = DateTime.Now;
            List<Message> rez = CreateRepository(dateTime);
            Filter filter = new Filter(subscriber: "+380501002030", messagePattern: "est", dateFrom: dateTime, dateTo: dateTime, isSubscriber: true, isMessagePattern: true, isPeriod: true, isOr: true);

            // Act
            var filterByUser = rez.Where(m => m.User == "+380501002030" || m.Text.Contains("est") || m.ReceivingTime >= dateTime && m.ReceivingTime <= dateTime).ToList();

            //Assert
            Assert.IsTrue(filterByUser.Except(filter.GetFilteredList(rez)).Count() == 0);
        }
    }
}