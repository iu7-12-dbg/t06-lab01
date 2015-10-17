using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
          
           /* Dictionary d1 = new Dictionary { Name = "Rus" };
            Dictionary d2 = new Dictionary { Name = "UK" };

            db.Dictionaries.Add(d1);
            db.Dictionaries.Add(d2);
            db.SaveChanges();*/

           /* Word w1 = new Word { Text = "Игорь", Dictionary = d1 };
            db.SaveChanges();*/

            return View(db.Dictionaries.ToList());
        }

        [HttpPost]
        public void CheckText(string inputedText)
        {
            

        }

    }
}
