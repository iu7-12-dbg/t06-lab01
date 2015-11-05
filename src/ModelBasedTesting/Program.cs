using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing;
using WordsProcessing.Algorithms;

namespace ModelBasedTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            WordsDictionaryModel model = new WordsDictionaryModel
            (
                new WagnerFischer(), new DictionaryFileFiller(@"Dictionaries/reducedUK.txt")
            );

            const int TestCount = 30;
            Random rnd = new Random();

            ExistingWordsTest(model, TestCount, rnd);
            RandomWordsTest(model, TestCount, rnd);

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }

        private static void RandomWordsTest(WordsDictionaryModel model, int TestCount, Random rnd)
        {
            for (int i = 0; i < TestCount; ++i)
            {
                int wordLen = rnd.Next(10);
                List<string> resList = model.GetClosestWords(GenerateWord(wordLen));
                Console.WriteLine("Test 2." + (i + 1) + " passed");
            }
        }

        private static void ExistingWordsTest(WordsDictionaryModel model, int TestCount, Random rnd)
        {
            for (int i = 0; i < TestCount; ++i)
            {
                string word = model.ModelImplementation.Words[rnd.Next(model.WordsCount)];
                List<string> resList = model.GetClosestWords(word);
                Console.WriteLine("Test 1." + (i + 1) + " passed");
            }
            Console.WriteLine();
        }

        static string GenerateWord(int wordLength)
        {
            Random rnd = new Random();
            string res = "";
            for (int i = 0; i < wordLength; ++i)
                res += ((char) rnd.Next((int)'a', (int)'z')).ToString();

            return res;
        }
    }
}
