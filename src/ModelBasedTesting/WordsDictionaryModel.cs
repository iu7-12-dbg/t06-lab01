using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Contract.Ensures(ModelImplementation.DictionaryFiller != null);
            ModelImplementation = new WordsDictionary(levDistance, dictionaryFiller);
        }

        /// <summary>
        /// Возвращает и устанавливает реализацию модели класса WordsDictionary.
        /// </summary>
        internal WordsDictionary ModelImplementation { get; set; }

        /// <summary>
        /// Находит все слова в словаре, для которых расстояние Левенштейна минимально.
        /// </summary>
        /// <param name="word">Заданное слово.</param>
        /// <returns>Список слов, для которых расстояние Левенштейна минимально.</returns>
        public List<string> GetClosestWords(string word)
        {
            Contract.Requires(word != null);
            Contract.Requires(ModelImplementation != null);
            Contract.Requires(ModelImplementation.LevDistance != null);
            Contract.Requires(ModelImplementation.Words != null);
            Contract.Requires(Contract.ForAll<string>(ModelImplementation.Words, str => str != ""));

            Contract.Ensures
            (
                (WordsCount > 0) 
                    ? (Contract.Result<List<string>>().Count > 0) 
                    : (Contract.Result<List<string>>().Count == 0)
            );
            Contract.Ensures
            (
                (ModelImplementation.Words.Contains(Contract.OldValue<string>(word))) 
                    ? (Contract.Result<List<string>>().Count == 1 && Contract.Result<List<string>>()[0] == word)
                    : (true)
            );

            return ModelImplementation.GetClosestWords(word);
        }

        /// <summary>
        /// Возвращает текущее количество слов в словаре.
        /// </summary>
        int WordsCount { get { return ModelImplementation.Words.Count; } }

        /// <summary>
        /// Инвариант объекта, описывает ожидаемое состояние класса, которое является валидным.
        /// </summary>
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(ModelImplementation != null);
            Contract.Invariant(ModelImplementation.Words != null);
            Contract.Invariant(WordsCount >= 0);
            Contract.Invariant(ModelImplementation.DictionaryFiller != null);
        }
    }
}
