using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class CartItem
    {
        [Key]
        public Guid ItemId { get; set; }
        public Guid CartId { get; set; }
        public int Quatity { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid BooksID { get; set; }
        public virtual Books Books { get; set; }
        public bool Borrowed { get; set; }
    }

    public class Cart
    {
        public string UserID { get; set; }
        [Key]
        public Guid ID { get; set; }
    }
}
