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
    /// с минимальным расстоянием Левенштейна по отношению к заданному слову.
    /// </summary>
    public class WordsDictionary : IWordsDictionary
    {
        /// <summary>
        /// Инициализирует объект класса и заполняет начальными значениями его члены.
        /// </summary>
        /// <param name="levDistance">Объект-алгоритм расчёта расстояния Левенштейна.</param>
        /// <param name="dictionaryFiller">Объект-наполнитель словаря.</param>
        public WordsDictionary(ILevenshteinDistance levDistance, IDictionaryFiller dictionaryFiller)
        {
            LevDistance = levDistance;
            DictionaryFiller = dictionaryFiller;
            FillDictionary();
        }

        /// <summary>
        /// Возвращает и устанавливает объект-алгоритм расчёта расстояния Левенштейна.
        /// </summary>
        internal ILevenshteinDistance LevDistance { get; set; }

        /// <summary>
        /// Возвращает и устанавливает реализацию интерфейса заполнителя словаря.
        /// </summary>
        internal IDictionaryFiller DictionaryFiller { get; set; }

        /// <summary>
        /// Возвращает и устанавливает коллекцию слов, по которым ведется поиск.
        /// </summary>
        internal List<string> Words { get; set; }

        /// <summary>
        /// Рассчитывает расстояние Левенштейна между заданным словом
        /// и словами в словаре
        /// </summary>
        /// <param name="word">Заданное слово</param>
        /// <returns>Список расстояний Левенштейна между заданным словом и словамя словаря</returns>
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
        /// <param name="distanceList">Список расстояний Левенштейна между заданным словом и словамя словаря</param>
        /// <returns>Список слов, для которых расстояние Левенштейна минимально</returns>
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
        /// <param name="word">Заданное слово</param>
        /// <returns>Список слов, для которых расстояние Левенштейна минимально</returns>
        public List<string> GetClosestWords(string word)
        {
            List<int> distanceList = CreateDistanceList(word);
            return GetListOfClosestWords(distanceList);
        }

        /// <summary>
        /// Заполняет словарь словами.
        /// </summary>
        private void FillDictionary()
        {
            Words = DictionaryFiller.Fill();
        }
    }
}
