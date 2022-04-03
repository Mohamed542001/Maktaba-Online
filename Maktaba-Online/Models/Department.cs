using System;
using System.Collections.Generic;

namespace Maktaba_Online.Models
{
    public partial class Department
    {
        public Department()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Photo { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
