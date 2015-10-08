﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordsProcessing;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class DictionaryProviderTest
    {
        /// <summary>
        /// Тестирует метод на правильное прочтение строк из файла.
        /// </summary>
        [TestMethod]
        public void ReadStringsFromFileTest()
        {
            // arrange
            string fileName = "test.txt";

            string[] origWords =
            {
                "First", 
                "Second",
                "Third",
                "Fourth",
                "Fifth",
                "Sixth"
            };

            if (File.Exists(fileName))
                File.Delete(fileName);

            File.WriteAllLines(fileName, origWords, Encoding.UTF8);

            // act
            List<string> words = DictionaryProvider.ReadStringsFromFile(fileName);

            // assert
            Assert.IsTrue(Enumerable.SequenceEqual(origWords, words.ToArray()));
        }
    }
}
