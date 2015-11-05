using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsProcessing
{
    /// <summary>
    /// Интерфейс словаря.
    /// </summary>
    public interface IWordsDictionary
    {
        /// <summary>
        /// Находит все слова в словаре, для которых расстояние Левенштейна минимально
        /// </summary>
        /// <param name="word">Заданное слово</param>
        /// <returns>Список слов, для которых расстояние Левенштейна минимально</returns>
        List<string> GetClosestWords(string word);
    }
}
