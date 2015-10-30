using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordsProcessing;
using WordsProcessing.Algorithms;
using WordsProcessingWeb.DAL;

namespace WordsProcessingWeb.Common
{
    public class ConcreteFactory : IFactory
    {
        public ILevenshteinDistance CreateLevenshteinDistanceAlgorithm()
        {
            LevenshteinDistanceCreator levenshteinDistanceCreator = 
                    new LevenshteinDistanceCreatorGeneric<WagnerFischer>();
            return levenshteinDistanceCreator.CreateLevenshteinDistanceAlgorithm();
        }

        public IDictionaryFiller CreateDictionaryFiller(string dictionaryFilename)
        {
            return new DictionaryFileFiller(dictionaryFilename);
        }

        public IDictionaryFiller CreateDictionaryFiller(DictionaryDBContext context, string dictionaryName)
        {
            return new DictionaryDBFiller(context, dictionaryName);
        }
    }
}