using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordsProcessing;

namespace WordsProcessingWeb.Common
{
    public abstract class LevenshteinDistanceCreator
    {
        public abstract ILevenshteinDistance CreateLevenshteinDistanceAlgorithm();
    }
}