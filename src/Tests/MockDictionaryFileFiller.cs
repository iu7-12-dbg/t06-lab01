using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing;

namespace Tests
{
    public class MockDictionaryFileFiller : IDictionaryFiller
    {
        public MockDictionaryFileFiller(List<string> words)
        {
            Words = words;
        }

        public List<string> Words { get; set; }

        public List<string> Fill()
        {
            return Words;
        }
    }
}
