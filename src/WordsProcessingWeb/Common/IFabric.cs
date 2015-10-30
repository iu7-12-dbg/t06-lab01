using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordsProcessing;
using WordsProcessingWeb.DAL;

namespace WordsProcessingWeb.Common
{
    public interface IFabric
    {
        public ILevenshteinDistance CreateLevenshteinDistance();

        public IDictionaryFiller CreateDictionaryFiller(string dictionaryFilename);

        public IDictionaryFiller CreateDictionaryFiller(DictionaryDBContext context, string dictionaryName);
    }
}