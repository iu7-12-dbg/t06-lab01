using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsProcessing
{
    /// <summary>
    /// Вспомогательный класс для WordsDictionary
    /// </summary>
    public class DictionaryProvider
    {
        /// <summary>
        /// Считывает строки из файла.
        /// </summary>
        /// <param name="dictionaryFileName">Коллекция считанных строк.</param>
        public static List<string> ReadStringsFromFile(string dictionaryFileName)
        {
            List<string> strings = new List<string>();

            StreamReader stream = new StreamReader(dictionaryFileName);
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                strings.Add(line);
            }
            stream.Close();

            return strings;
        }
    }
}
