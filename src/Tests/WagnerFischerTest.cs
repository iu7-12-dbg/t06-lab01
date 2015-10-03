using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing.Algorithms;

namespace Tests
{
    [TestClass]
    public class WagnerFischerTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void LevinsteinDistanceTest1()
        {
            //arrange
            WagnerFischer levDistance = new WagnerFischer();

            //action
            int distance = levDistance.CalcLevenshteinDistance(null, "Stroka2");

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void LevinsteinDistanceTest2()
        {
            //arrange
            WagnerFischer levDistance = new WagnerFischer();

            //action
            int distance = levDistance.CalcLevenshteinDistance("Stroka1", null);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void LevinsteinDistanceTest3()
        {
            //arrange
            WagnerFischer levDistance = new WagnerFischer();

            //action
            int distance = levDistance.CalcLevenshteinDistance("", "Stroka2");

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void LevinsteinDistanceTest4()
        {
            //arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 3;

            //act
            int distance = levDistance.CalcLevenshteinDistance("holera", "opera");

            //assert
            Assert.AreEqual(sampleDistance, distance);
        }

        [TestMethod]
        public void LevinsteinDistanceTest5()
        {
            //arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 5;

            //act
            int distance = levDistance.CalcLevenshteinDistance("opera", "ghost");

            //assert
            Assert.AreEqual(sampleDistance, distance);
        }

        [TestMethod]
        public void LevinsteinDistanceTest6()
        {
            //arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 3;

            //act
            int distance = levDistance.CalcLevenshteinDistance("ditance", "distance");

            //assert
            Assert.AreEqual(sampleDistance, distance);
        }

        [TestMethod]
        public void LevinsteinDistanceTest7()
        {
            //arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 3;

            //act
            int distance = levDistance.CalcLevenshteinDistance("yndeex", "yandex");

            //assert
            Assert.AreEqual(sampleDistance, distance);
        }
    }
}
