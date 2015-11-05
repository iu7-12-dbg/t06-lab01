using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsProcessing
{
    /// <summary>
    /// Интерфейс заполнения словаря.
    /// </summary>
    public interface IDictionaryFiller
    {
        /// <summary>
        /// Возвращает список слов.
        /// </summary>
        /// <returns></returns>
        List<string> Fill();
    }
}
