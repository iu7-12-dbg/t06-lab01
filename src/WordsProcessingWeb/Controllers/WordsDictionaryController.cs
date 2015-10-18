using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

            return View(db.Dictionaries.ToList());
        }

        [HttpPost]
        public void CheckText(string inputedText)
        {
            

        }

    }
}
