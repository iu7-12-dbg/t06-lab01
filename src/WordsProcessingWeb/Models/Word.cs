using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordsProcessingWeb.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? DictionaryId { get; set; }
        public virtual Dictionary Dictionary { get; set; }
    }
}