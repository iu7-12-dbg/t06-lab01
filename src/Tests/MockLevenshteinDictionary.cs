using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing;

namespace Tests
{
    class MockLevenshteinDictionary : ILevenshteinDistance
    {
        public MockLevenshteinDictionary()
        {
            CalcLevenshteinDistanceEnters = 0;
        }

        public int CalcLevenshteinDistanceEnters { get; set; }

        public int DeletionWeight
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int ReplacementWeight
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int InsertionWeight
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int CalcLevenshteinDistance(string firstString, string secondString)
        {
            CalcLevenshteinDistanceEnters++;
            return 0;
        }
    }
}
