using System;
using System.Collections.Generic;

#nullable disable

namespace pharmEasy.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int CartId { get; set; }
        public int? CustomerId { get; set; }
        public long? SubTotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
