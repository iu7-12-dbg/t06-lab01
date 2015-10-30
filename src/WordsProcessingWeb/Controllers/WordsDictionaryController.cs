using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordsProcessing;
using WordsProcessing.Algorithms;
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
                WordsDictionary dictionary = new WordsDictionary(new WagnerFischer());
                string language = Request.Form["Language"].ToString();
                if (language == "RUS")
                {
                    dictionary.Words = db.Words.Where(word => word.Dictionary.Name == "Rus").Select(word => word.Text).ToList();
                }
                else if (language == "ENG")
                {
                    dictionary.Words = db.Words.Where(word => word.Dictionary.Name == "UK").Select(word => word.Text).ToList();
                }
                List<string> closestWords = dictionary.GetClosestWords(inputedWord);

                for (int i = 0; i < closestWords.Count; i++)
                {
                    Word word = new Word() { Text = closestWords[i] };
                    words.Add(word);
                }
            }

            
            return View(words);
        }

    }
}
