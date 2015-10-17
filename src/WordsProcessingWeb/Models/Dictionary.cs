using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WordsProcessingWeb.Models
{
    public class Dictionary
    {
        public Dictionary()
        {
            Words = new List<Word>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Word> Words { get; set; }
    }

    public class DictionaryDBContext : DbContext
    {
        public DbSet<Dictionary> Dictionaries { get; set; }
    }
}