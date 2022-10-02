using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            //arguments: expected, actual, delta
            Assert.AreEqual(10, 10, .001);
        }

        Car test_car;

        //will run before each test method in a class
        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {

            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasLevelWithinRange()
        {
            test_car.Drive(100);
            Assert.AreEqual(8, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasLevelOutsideRange()
        {
            test_car.Drive(550);
            Assert.AreEqual(0, test_car.GasTankLevel, .001);

        }
        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }

    }
}
