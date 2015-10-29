﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsProcessing
{
    public class DictionaryFileFiller : IDictionaryFiller
    {
        public DictionaryFileFiller(string dictionaryFileName)
        {
            if (dictionaryFileName == null || dictionaryFileName == "")
                throw new ArgumentNullException("String dictionaryFileName can't be empty.");

            DictionaryFileName = (string) dictionaryFileName.Clone();
        }

        private string DictionaryFileName { get; set; }

        public List<string> Fill()
        {
            List<string> strings = new List<string>();

            try
            {
                StreamReader stream = new StreamReader(DictionaryFileName);
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    strings.Add(line);
                }
                stream.Close();
            }
            catch(Exception e)
            {
                throw new Exception("Error, while reading dictionary file.", e);
            }

            return strings;
        }
    }
}
