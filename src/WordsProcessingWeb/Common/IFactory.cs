using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordsProcessing;
using WordsProcessingWeb.DAL;

namespace WordsProcessingWeb.Common
{
    public interface IFactory
    {
        ILevenshteinDistance CreateLevenshteinDistanceAlgorithm();

        IDictionaryFiller CreateDictionaryFiller(string dictionaryFilename);

        IDictionaryFiller CreateDictionaryFiller(DictionaryDBContext context, string dictionaryName);
    }
}