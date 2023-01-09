using System;
using System.Collections.Generic;

#nullable disable

namespace pharmEasy.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Carts = new HashSet<Cart>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            Orders = new HashSet<Order>();
            ShortLists = new HashSet<ShortList>();
        }

        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public long? PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ShortList> ShortLists { get; set; }
    }
}
