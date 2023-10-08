using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class StarCalculatorTests
    {

        [TestMethod()]
        [DataRow(0.08883, 36.72)]
        public void GetDistanceInLightYearsTest(double parallax, double distance)
        {
            var distanceTest = StarCalculator.GetDistanceInLightYears(parallax);
            Assert.AreEqual(distance, distanceTest);
            
        }

        [TestMethod()]
        [DataRow(0.02339, 42.75)]
        public void GetDistanceInParsecsTest(double parallax, double distance)
        {
            var distanceTest = StarCalculator.GetDistanceInParsecs(parallax);
            Assert.AreEqual(distance, distanceTest);
        }

        [TestMethod()]
        [DataRow(0.02339, 42.75)]
        public void GetParallaxInArcsecTest(double parallax, double distance)
        {
            var parallaxTest = StarCalculator.GetParallaxInArcsec(distance);
            Assert.AreEqual(parallax, parallaxTest);
        }
    }
}