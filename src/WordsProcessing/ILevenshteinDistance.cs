using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsProcessing
{
    /// <summary>
    /// Интерфейс ILevenshteinDistance
    /// объявляет метод расчета расстояние Левенштейна между двумя строками
    /// </summary>
    public interface ILevenshteinDistance
    {
        /// <summary>
        /// Метод CalcLevenshteinDistance
        /// рассчитывает расстояние Левенштейна между двумя строками
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        int CalcLevenshteinDistance(string firstString, string secondString);
    }
}
