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
    /// Содержит словарь слов, по которому осуществляет поиск слов
    /// с минимальным расстоянием Левенштейна по отношению к заданному слову
    /// </summary>
    public class WordsDictionary
    {
        /// <summary>
        /// Инициализирует объект класса и заполняет начальными значениями его члены
        /// </summary>
        public WordsDictionary(ILevenshteinDistance levDistance)
        {
            LevDistance = levDistance;
            Words = new List<string>();
        }

        /// <summary>
        /// Возвращает и устанавливает объект-алгоритм расчёта расстояния Левенштейна.
        /// </summary>
        ILevenshteinDistance LevDistance { get; set; }

        /// <summary>
        /// Возвращает и устанавливает коллекцию слов, по которым ведется поиск.
        /// </summary>
        public List<string> Words { get; set; }

        /// <summary>
        /// Рассчитывает расстояние Левенштейна между заданным словом
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
        /// Находит слова, для которых расстояние Левенштейна минимально среди всех рассчитанных расстояний;
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
        /// Находит все слова в словаре, для которых расстояние Левенштейна минимально
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
