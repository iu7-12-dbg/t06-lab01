using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordsProcessing;
using System.Collections.Generic;
using WordsProcessing.Algorithms;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class WordsDictionaryTest
    {
        /// <summary>
        /// Тестирует количество заходов в алгоритм поиска редакционного расстояния.
        /// </summary>
        [TestMethod]
        public void GetListOfClosestWordsCountTest()
        {
            // arrange
            MockLevenshteinDictionary levDist = new MockLevenshteinDictionary();
            WordsDictionary dic = new WordsDictionary(levDist);
            List<string> origWords = new List<string>()
            {
                "First", 
                "Second",
                "Third",
                "Fourth",
                "Fifth",
                "Sixth"
            };
            dic.Words = origWords;
             
            // act
            List<string> res = dic.GetClosestWords("Seventh");

            // assert
            Assert.AreEqual(origWords.Count, levDist.CalcLevenshteinDistanceEnters);
        }

        /// <summary>
        /// Функциональный тест.
        /// </summary>
        [TestMethod]
        public void GetListOfClosestWordsFuncTest()
        {
            // arrange
            ILevenshteinDistance levDist = new WagnerFischer();
            WordsDictionary dic = new WordsDictionary(levDist);
            List<string> origWords = new List<string>()
            {
                "First", 
                "Second",
                "Third",
                "Fourth",
                "Fifth",
                "Sixth"
            };
            dic.Words = origWords;
            List<string> resWords = new List<string>()
            {
                "First",
                "Fifth"
            };
            // act
            List<string> res = dic.GetClosestWords("Funci");

            // assert
            Assert.IsTrue(Enumerable.SequenceEqual(resWords, res));
        }
    }
}
