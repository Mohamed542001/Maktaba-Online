using System;
using System.Collections.Generic;

namespace Maktaba_Online.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? BookId { get; set; }
        public int? Qty { get; set; }

        public virtual Book? Book { get; set; }
    }
}
