using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing.Algorithms;

namespace WordsProcessing
{
    public class WordsDictionary
    {
        ILevenshteinDistance LevDistance { get; set; }
        List<string> Words { get; set; }

        public WordsDictionary() 
        {
            LevDistance = new WagnerFischer();
            Words = new List<string>();
        }

        public void AddWordsToDictionary(string dictionaryFileName)
        {
            StreamReader file = new StreamReader(dictionaryFileName);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                Words.Add(line);
            }

            file.Close();
        }

        private List<int> CreateDistanceList(string word)
        {
            List<int> distanceList = new List<int>();
            for (int i = 0; i < Words.Count; i++)
            {
                int distance = LevDistance.CalcLevenshteinDistance(word, Words[i]);
                distanceList.Add(distance);
            }
            return distanceList;
        }

       
        private List<string> GetListOfClosestWords(List<int> distanceList)
        {
            List<string> closestWords = new List<string>();
            int minDistance = distanceList.Min();
            for (int i = 0; i < distanceList.Count; i++)
            {
                if (distanceList[i] == minDistance)
                {
                    closestWords.Add(Words[i]);
                }
            }
            return closestWords;
        }
    

        public List<string> GetClosestWords(string word)
        {
            List<int> distanceList = CreateDistanceList(word);
            return GetListOfClosestWords(distanceList);
        }
    }
}
