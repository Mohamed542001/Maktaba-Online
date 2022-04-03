using System;
using System.Collections.Generic;

namespace Maktaba_Online.Models
{
    public partial class Book
    {
        public Book()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Deptid { get; set; }
        public string? Photo { get; set; }

        public virtual Department? Dept { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
