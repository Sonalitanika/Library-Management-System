using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Books
    {
        public Guid ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        [Display(Name = "Number of Copies")]
        public int Copies { get; set; }
    }

    public enum SearchType
    {
        Author,
        Title
    }
}
