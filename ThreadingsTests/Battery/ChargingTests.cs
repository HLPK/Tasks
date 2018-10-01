using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryMobile.Battery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse;
using CSharpCourse.Battery;
using CSharpCourse.KeyBoards;
using CSharpCourse.Screens;
using System.Threading;

namespace ClassLibraryMobile.Battery.Tests {
    [TestClass()]
    public class ChargingTests {

        [TestMethod()]
        public void MoreThen0Test() {
            //Arrange
            ChargingBattery charger = new ChargingBatteryByThread();
            charger.Battery = new LiIonBattery();
            Thread dischargeThread = new Thread(new ThreadStart(charger.Discharging));
            dischargeThread.IsBackground = true;

            //Act
            charger.Battery.Charge = 2;
            dischargeThread.Start();
            Thread.Sleep(4000);
            dischargeThread.Abort();

            //Assert
            Assert.IsTrue(charger.Battery.Charge >= 0);
        }

        [TestMethod()]
        public void NoMoreThen100Test() {
            //Arrange
            ChargingBattery charger = new ChargingBatteryByThread();
            charger.Battery = new LiIonBattery();
            Thread chargeThread = new Thread(new ThreadStart(charger.Charging));
            chargeThread.IsBackground = true;

            //Act
            charger.Battery.Charge = 98;
            chargeThread.Start();
            Thread.Sleep(4000);
            chargeThread.Abort();

            //Assert
            Assert.IsTrue(charger.Battery.Charge <= 100);
        }

        [TestMethod()]
        public void ChargeInTurnOffThread() {
            //Arrange
            BatteryBase battery = new LiPolBattery();
            battery.Charge = 100;
            ChargingBattery charger = new ChargingBatteryByThread(battery);

            //Act
            Thread.Sleep(4000);

            //Assert
            Assert.IsTrue(charger.Battery.Charge < 100);
        }

        [TestMethod()]
        public void ChargeInTurnOnThread() {
            //Arrange
            BatteryBase battery = new LiPolBattery();
            battery.Charge = 98;
            ChargingBattery charger = new ChargingBatteryByThread();
            charger.Battery = battery;

            //Act
            charger.Charge();
            Thread.Sleep(4000);

            //Assert
            Assert.IsTrue(charger.Battery.Charge == 100);
        }

        [TestMethod()]
        public void ChargeInTurnOffTask() {
            //Arrange
            BatteryBase battery = new LiPolBattery();
            battery.Charge = 100;
            ChargingBattery charger = new ChargingBatteryByTask(battery);

            //Act
            Thread.Sleep(4000);

            //Assert
            Assert.IsTrue(charger.Battery.Charge < 100);
        }

        [TestMethod()]
        public void ChargeInTurnOnTask() {
            //Arrange
            BatteryBase battery = new LiPolBattery();
            battery.Charge = 90;
            ChargingBattery charger = new ChargingBatteryByTask(battery);

            //Act
            charger.Charge();
            Thread.Sleep(4000);

            //Assert
            Assert.IsTrue(charger.Battery.Charge > 90);
        }
    }
}