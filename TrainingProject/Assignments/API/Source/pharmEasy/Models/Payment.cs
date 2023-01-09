using System;
using System.Collections.Generic;

#nullable disable

namespace pharmEasy.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }

        public int PaymentId { get; set; }
        public int? PaymentType { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentStatus { get; set; }
        public decimal? Amount { get; set; }

        public virtual Attribute PaymentStatusNavigation { get; set; }
        public virtual Attribute PaymentTypeNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
