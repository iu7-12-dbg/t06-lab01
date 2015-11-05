using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing;

namespace ModelBasedTesting
{
    /// <summary>
    /// Ограничительная модель словаря.
    /// </summary>
    class WordsDictionaryModel : IWordsDictionary
    {
        /// <summary>
        /// Инициализирует объект класса и заполняет начальными значениями его члены.
        /// </summary>
        /// <param name="levDistance">Объект-алгоритм расчёта расстояния Левенштейна.</param>
        /// <param name="dictionaryFiller">Объект-наполнитель словаря.</param>
        public WordsDictionaryModel(ILevenshteinDistance levDistance, IDictionaryFiller dictionaryFiller)
        {
            ModelImplementation = new WordsDictionary(levDistance, dictionaryFiller);
        }

        /// <summary>
        /// Возвращает и устанавливает реализацию модели класса WordsDictionary.
        /// </summary>
        WordsDictionary ModelImplementation { get; set; }

        /// <summary>
        /// Находит все слова в словаре, для которых расстояние Левенштейна минимально.
        /// </summary>
        /// <param name="word">Заданное слово.</param>
        /// <returns>Список слов, для которых расстояние Левенштейна минимально.</returns>
        public List<string> GetClosestWords(string word)
        {
            return ModelImplementation.GetClosestWords(word);
        }

        /// <summary>
        /// Возвращает текущее количество слов в словаре.
        /// </summary>
        int WordsCount { get { return ModelImplementation.Words.Count; } }
    }
}
