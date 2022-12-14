using System;
using System.Collections.Generic;

#nullable disable

namespace pharmEasy.Models
{
    public partial class Category
    {
        public Category()
        {
            InverseParentCategoryNavigation = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategory { get; set; }
        public string Description { get; set; }

        public virtual Category ParentCategoryNavigation { get; set; }
        public virtual ICollection<Category> InverseParentCategoryNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
