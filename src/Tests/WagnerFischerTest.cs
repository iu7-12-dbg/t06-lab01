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
        public void WagnerFischerTest1()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance(null, "Stroka2");
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void WagnerFischerTest2()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance("Stroka1", null);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void WagnerFischerTest3()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance("", "Stroka2");
        }

        [TestMethod]
        public void WagnerFischerTest4()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 3;

            // act
            int distance = levDistance.CalcLevenshteinDistance("holera", "opera");

            // assert
            Assert.AreEqual(sampleDistance, distance);
        }

        [TestMethod]
        public void WagnerFischerTest5()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 5;

            // act
            int distance = levDistance.CalcLevenshteinDistance("opera", "ghost");

            // assert
            Assert.AreEqual(sampleDistance, distance);
        }

        [TestMethod]
        public void WagnerFischerTest6()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 3;

            // act
            int distance = levDistance.CalcLevenshteinDistance("ditance", "distance");

            // assert
            Assert.AreEqual(sampleDistance, distance);
        }

        [TestMethod]
        public void WagnerFischerTest7()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 3;

            // act
            int distance = levDistance.CalcLevenshteinDistance("yndeex", "yandex");

            // assert
            Assert.AreEqual(sampleDistance, distance);
        }
    }
}
