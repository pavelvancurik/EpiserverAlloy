using System;
using EpiserverAlloy.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PricingTestProject
{
    [TestClass]
    public class PricingTest
    {
        PricingService pricingService = new PricingService();

        [TestMethod]
        public void TestGetInidividualPrice()
        {
            double? expected = 32.94;
            double? actual = pricingService.GetInidividualPrice(36.00, 7, true, true, null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWithoutOnlineDiscount()
        {
            double? expected = 113.5112;
            double? actual = pricingService.GetInidividualPrice(128.99, 12, true, false, null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNotLoggedUser()
        {
            double? expected = null;
            double? actual = pricingService.GetInidividualPrice(128.99, 0, false, true, null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWithMaxDiscount()
        {
            double? expected = 32.4;
            double? actual = pricingService.GetInidividualPrice(36.00, 15, true, false, 10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWithDecreasedMaxDiscount()
        {
            double? expected = 30.96;
            double? actual = pricingService.GetInidividualPrice(36.00, 15, true, false, 14);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWithDecreasedMaxDiscountOnlineDiscount()
        {
            double? expected = 30.96;
            double? actual = pricingService.GetInidividualPrice(36.00, 15, true, true, 14);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Max discount is out of range.")]
        public void TestWhetherExceptionIsThrown()
        {
            double? actual = pricingService.GetInidividualPrice(36.00, 15, true, true, 26);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Max discount is out of range.")]
        public void TestWhetherExceptionIsThrownIfNegativeMaxDiscount()
        {
            double? actual = pricingService.GetInidividualPrice(36.00, 15, true, true, -1);
        }
    }
}
