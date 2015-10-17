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
            return View();
        }

    }
}
