using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordsProcessing;

namespace WordsProcessingWeb.Common
{
    public class LevenshteinDistanceCreatorGeneric<T> 
        : LevenshteinDistanceCreator where T : ILevenshteinDistance, new()
    {
        public override ILevenshteinDistance CreateLevenshteinDistanceAlgorithm()
        {
            ILevenshteinDistance levenshteinDistanceAlgorithm = new T();
            return levenshteinDistanceAlgorithm;
        }
    }
}