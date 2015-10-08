using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsProcessing
{
    /// <summary>
    /// Интерфейс классов расчета расстояния Левенштейна между двумя строками
    /// </summary>
    public interface ILevenshteinDistance
    {
        /// <summary>
        /// Возвращает и устанавливает вес удаления.
        /// </summary>
        int DeletionWeight { get; set; }

        /// <summary>
        /// Возвращает и устанавливает вес замены.
        /// </summary>
        int ReplacementWeight { get; set; }

        /// <summary>
        /// Возвращает и устанавливает вес вставки.
        /// </summary>
        int InsertionWeight { get; set; }

        /// <summary>
        /// Рассчитывает расстояние Левенштейна между двумя строками
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        int CalcLevenshteinDistance(string firstString, string secondString);
    }
}
