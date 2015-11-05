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
            WordsDictionaryModel model = 
                    new WordsDictionaryModel(new WagnerFischer(), new DictionaryFileFiller(@"Dictionaries/UK.txt"));

            List<string> resList = model.GetClosestWords("mashine");
            foreach (string word in resList)
                Console.WriteLine(word);

            Console.ReadKey();
        }
    }
}
