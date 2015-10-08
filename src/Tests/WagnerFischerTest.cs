using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing;
using WordsProcessing.Algorithms;

namespace Tests
{
    /// <summary>
    /// Реализует тестирование алгоритма Вагнера-Фишера
    /// </summary>
    [TestClass]
    public class WagnerFischerTest
    {
		/// <summary>
        /// Тестирует расчет расстояния Левенштейна между строкой, представляющей пустую ссылку, (1й аргумент) и непустой строкой (2й аргумент) - "Stroka2"
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WagnerFischerFirstNullArgumentTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance(null, "Stroka2");
        }

		/// <summary>
        /// Тестирует расчет расстояния Левенштейна между непустой строкой (1й аргумент) - "Stroka1" - и строкой, представляющей пустую ссылку (2й аргумент)
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WagnerFischerSecondNullArgumentTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance("Stroka1", null);
        }

        /// <summary>
        /// Тестирует расчет расстояния Левенштейна между двумя строками, ссылки на которые равны null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WagnerFischerBothNullArgumentsTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance(null, null);
        }


		/// <summary>
        /// Тестирует расчет расстояния Левенштейна между пустой строкой (1й аргумент) и непустой строкой (2й аргумент) - "Stroka"
        /// </summary>
        [TestMethod]
        public void WagnerFischerFirstEmptyStringTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();
            string testString = "Stroka";

            // act
            int distance = levDistance.CalcLevenshteinDistance("", testString);

            // assert
            Assert.AreEqual(testString.Length * levDistance.InsertionWeight, distance);
        }

        /// <summary>
        /// Тестирует расчет расстояния Левенштейна между непустой строкой (1й аргумент) и пустой строкой (2й аргумент) - "Stroka2"
        /// </summary>
        [TestMethod]
        public void WagnerFischerSecondEmptyStringTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();
            string testString = "Stroka2";

            // act
            int distance = levDistance.CalcLevenshteinDistance(testString, "");

            // assert
            Assert.AreEqual(testString.Length * levDistance.DeletionWeight, distance);
        }

        /// <summary>
        /// Тестирует расчет расстояния Левенштейна между двумя пустыми строками
        /// </summary>
        [TestMethod]
        public void WagnerFischerBothEmptyStringTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();

            // act, assert
            int distance = levDistance.CalcLevenshteinDistance("", "");

            // assert
            Assert.AreEqual(0, distance);
        }
		
		/// <summary>
        /// Тестирует расчет расстояния Левенштейна между двумя непустыми строками - "opera" и "hopera" - расстояние 
        /// Левенштейна между которыми равно одной вставке.
        /// </summary>
        [TestMethod]
        public void WagnerFischerInsertionTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();

            // act
            int distance = levDistance.CalcLevenshteinDistance("opera", "hopera");

            // assert
            Assert.AreEqual(levDistance.InsertionWeight, distance);
        }

        /// <summary>
        /// Тестирует расчет расстояния Левенштейна между двумя непустыми строками - "yandex" и "yardex" - расстояние 
        /// Левенштейна между которыми равно одной замене.
        /// </summary>
        [TestMethod]
        public void WagnerFischerReplacementTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();

            // act
            int distance = levDistance.CalcLevenshteinDistance("yandex", "yardex");

            // assert
            Assert.AreEqual(levDistance.ReplacementWeight, distance);
        }

        /// <summary>
        /// Тестирует расчет расстояния Левенштейна между двумя непустыми строками - "distance" и "ditance" - расстояние 
        /// Левенштейна между которыми равно одному удалению.
        /// </summary>
        [TestMethod]
        public void WagnerFischerDeletionTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();

            // act
            int distance = levDistance.CalcLevenshteinDistance("distance", "ditance");

            // assert
            Assert.AreEqual(levDistance.DeletionWeight, distance);
        }

		/// <summary>
        /// Тестирует расчет расстояния Левенштейна между двумя непустыми строками - "opera" и "ghosts", 
        /// между которыми есть вставки и замены.
        /// </summary>
        [TestMethod]
        public void WagnerFischerInsertionReplacementTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();
            string testString1 = "opera";
            string testString2 = "ghosts";

            // act
            int distance = levDistance.CalcLevenshteinDistance(testString1, testString2);

            // assert
            Assert.AreEqual(levDistance.ReplacementWeight * testString1.Length + 
                    (testString2.Length - testString1.Length) * levDistance.InsertionWeight, distance);
        }

        /// <summary>
        /// Тестирует расчет расстояния Левенштейна между двумя непустыми строками - "ghosts" и "opera",
        /// между которыми есть удаления и замены.
        /// </summary>
        [TestMethod]
        public void WagnerFischerDeletionReplacementTest()
        {
            // arrange
            ILevenshteinDistance levDistance = new WagnerFischer();
            string testString1 = "ghosts";
            string testString2 = "opera";

            // act
            int distance = levDistance.CalcLevenshteinDistance(testString1, testString2);

            // assert
            Assert.AreEqual(levDistance.ReplacementWeight * testString2.Length +
                    (testString1.Length - testString2.Length) * levDistance.DeletionWeight, distance);
        }
		
		/// <summary>
        /// Тестирует расчет расстояния Левенштейна между двумя непустыми строками одинаковыми строками - "excellent" - расстояние 
        /// Левенштейна между которыми равно 0
        /// </summary>
        [TestMethod]
        public void WagnerFischerEqualTest()
        {
            //arrange
            ILevenshteinDistance levDistance = new WagnerFischer();

            //act
            int distance = levDistance.CalcLevenshteinDistance("excellent", "excellent");

            //assert
            Assert.AreEqual(0, distance);
        }
    }
}
