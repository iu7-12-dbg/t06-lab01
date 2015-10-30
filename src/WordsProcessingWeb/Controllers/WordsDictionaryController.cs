using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordsProcessing;
using WordsProcessing.Algorithms;
using WordsProcessingWeb.Common;
using WordsProcessingWeb.DAL;
using WordsProcessingWeb.Models;

namespace WordsProcessingWeb.Controllers
{
    public class WordsDictionaryController : Controller
    {
        DictionaryDBContext db = new DictionaryDBContext();

        public ActionResult Index()
        {
            List<Word> words = new List<Word>();
            return View(words);
        }

        [HttpPost]
        public ActionResult ResultWords(string inputedWord)
        {
            List<Word> words = new List<Word>();
            if (inputedWord != null)
            {
                string language = Request.Form["Language"].ToString();
                string dictionaryFilename = AppDomain.CurrentDomain.BaseDirectory + "/Dictionaries/UK.txt";

                WordsDictionary dictionary = new WordsDictionary(
                        Singleton.Instance.Fabric.CreateLevenshteinDistanceAlgorithm(),
                        Singleton.Instance.Fabric.CreateDictionaryFiller(db, language)
                        //Singleton.Instance.Fabric.CreateDictionaryFiller(dictionaryFilename)
                );
                
                List<string> closestWords = dictionary.GetClosestWords(inputedWord);

                foreach (string word in closestWords) 
                {
                    words.Add(new Word() { Text = word });
                }
            }

            return View(words);
        }

    }
}
