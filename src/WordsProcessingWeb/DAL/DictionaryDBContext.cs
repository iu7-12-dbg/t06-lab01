using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WordsProcessingWeb.Models;

namespace WordsProcessingWeb.DAL
{
    public class DictionaryDBContext : DbContext
    {
        public DbSet<Dictionary> Dictionaries { get; set; }
    }
}