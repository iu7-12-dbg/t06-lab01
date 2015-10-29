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
        //
        // GET: /WordsDictionary/

        public ActionResult Index()
        {
            /* List<Dictionary> result = (from a in db.Dictionaries
                         
                          select a).ToList();

         
            db.Dictionaries.Remove(result[0]);
            db.Dictionaries.Remove(result[1]);
            db.SaveChanges();  */
           
          /* Dictionary d1 = new Dictionary { Name = "Rus" };
            Dictionary d2 = new Dictionary { Name = "UK" };

            

            Word w1 = new Word { Text = "Игорь" };
            d1.Words.Add(w1);

            db.Dictionaries.Add(d1);
            db.Dictionaries.Add(d2);
            db.SaveChanges();
            int a = 10;
            a = 0;*/
            
         //   db.SaveChanges();

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
