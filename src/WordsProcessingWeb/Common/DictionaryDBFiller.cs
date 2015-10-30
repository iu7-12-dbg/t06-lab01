using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordsProcessing;
using WordsProcessingWeb.DAL;

namespace WordsProcessingWeb.Common
{
    public class DictionaryDBFiller : IDictionaryFiller
    {
        public DictionaryDBFiller(DictionaryDBContext context, string dictionaryName)
        {
            Context = context;
            DictionaryName = dictionaryName;
        }

        DictionaryDBContext Context { get; set; }

        string DictionaryName { get; set; }

        public List<string> Fill()
        {
            return Context.Words.Where(word => word.Dictionary.Name == DictionaryName).Select(word => word.Text).ToList();
        }
    }
}