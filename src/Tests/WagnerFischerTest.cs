using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing.Algorithms;

namespace Tests
{
    /// <summary>
    /// Класс WagnerFischerTest
    /// реализует тестирование алгоритма Вагнера-Фишера
    /// </summary>
    [TestClass]
    public class WagnerFischerTest
    {
		/// <summary>
        /// Метод LevinsteinDistanceTest1
        /// тестирует расчет расстояния Левенштейна между строкой, представляющей пустой указатель, (1й аргумент) и непустой строкой (2й аргумент) - "Stroka2"
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void WagnerFischerTest1()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance(null, "Stroka2");
        }

		/// <summary>
        /// Метод LevinsteinDistanceTest2
        /// тестирует расчет расстояния Левенштейна между непустой строкой (1й аргумент) - "Stroka1" - и строкой, представляющей пустой указатель (2й аргумент)
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void WagnerFischerTest2()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance("Stroka1", null);
        }

		/// <summary>
        /// Метод LevinsteinDistanceTest3
        /// тестирует расчет расстояния Левенштейна между пустой строкой (1й аргумент) и непустой строкой (2й аргумент) - "Stroka2"
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void WagnerFischerTest3()
        {
            // arrange
            WagnerFischer levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance("", "Stroka2");
        }

		
		/// <summary>
        /// Метод LevinsteinDistanceTest4
        /// тестирует расчет расстояния Левенштейна между двумя непустыми строками - "holera" и "opera" - расстояние Левенштейна между которыми равно 3
        /// </summary>
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

		/// <summary>
        /// Метод LevinsteinDistanceTest5
        /// тестирует расчет расстояния Левенштейна между двумя непустыми строками - "opera" и "ghost" - расстояние Левенштейна между которыми равно 5
        /// </summary>
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

        /// <summary>
        /// Метод LevinsteinDistanceTest6
        /// тестирует расчет расстояния Левенштейна между двумя непустыми строками - "ditance" и "distance" - расстояние Левенштейна между которыми равно 3
        /// </summary>
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

        /// <summary>
        /// Метод LevinsteinDistanceTest7
        /// тестирует расчет расстояния Левенштейна между двумя непустыми строками - "yndeex" и "yandex" - расстояние Левенштейна между которыми равно 3
        /// </summary>
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
		
		/// <summary>
        /// Метод LevinsteinDistanceTest8
        /// тестирует расчет расстояния Левенштейна между двумя непустыми строками одинаковыми строками - "excelent" - расстояние Левенштейна между которыми равно 0
        /// </summary>
        [TestMethod]
        public void LevinsteinDistanceTest8()
        {
            //arrange
            WagnerFischer levDistance = new WagnerFischer();
            int sampleDistance = 0;

            //act
            int distance = levDistance.CalcLevenshteinDistance("excelent", "excelent");

            //assert
            Assert.AreEqual(sampleDistance, distance);
        }
    }
}
