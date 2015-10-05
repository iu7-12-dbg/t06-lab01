using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing.Algorithms;

namespace WordsProcessing
{
    /// <summary>
    /// Класс WordsDictionary
    /// содержит словарь слов, по которому осуществляет поиск слов
    /// с минимальным расстоянием Левенштейна по отношению к заданному слову
    /// </summary>
    public class WordsDictionary
    {
        ILevenshteinDistance LevDistance { get; set; }
        List<string> Words { get; set; }

        /// <summary>
        /// Конструктор WordsDictionary
        /// инициализирует объект класса и заполняет начальными значениями его члены
        /// </summary>
        public WordsDictionary(ILevenshteinDistance levDistance) 
        {
            LevDistance = levDistance;
            Words = new List<string>();
        }

        /// <summary>
        /// Метод AddWordsToDictionary
        /// добавляет в словарь слова из файла с заданным именем
        /// </summary>
        /// <param name="dictionaryFileName"></param>
        public void AddWordsToDictionary(string dictionaryFileName)
        {
            StreamReader file = new StreamReader(dictionaryFileName);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                Words.Add(line);
            }

            file.Close();
        }

        /// <summary>
        /// Метод CreateDistanceList
        /// рассчитывает расстояние Левенштейна между заданным словом
        /// и словами в словаре
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private List<int> CreateDistanceList(string word)
        {
            List<int> distanceList = new List<int>();
            for (int i = 0; i < Words.Count; i++)
            {
                int distance = LevDistance.CalcLevenshteinDistance(word, Words[i]);
                distanceList.Add(distance);
            }
            return distanceList;
        }

        /// <summary>
        /// Метод GetListOfClosestWords
        /// находит слова, для которых расстояние Левенштейна минимально среди всех рассчитанных расстояний;
        /// </summary>
        /// <param name="distanceList"></param>
        /// <returns></returns>
        private List<string> GetListOfClosestWords(List<int> distanceList)
        {
            List<string> closestWords = new List<string>();
            int minDistance = distanceList.Min();
            for (int i = 0; i < distanceList.Count; i++)
            {
                if (distanceList[i] == minDistance)
                {
                    closestWords.Add(Words[i]);
                }
            }
            return closestWords;
        }

        /// <summary>
        /// Метод GetClosestWords
        /// находит все слова в словаре, для которых расстояние Левенштейна минимально
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public List<string> GetClosestWords(string word)
        {
            List<int> distanceList = CreateDistanceList(word);
            return GetListOfClosestWords(distanceList);
        }
    }
}
