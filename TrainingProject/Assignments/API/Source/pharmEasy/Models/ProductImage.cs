﻿using System;
using System.Collections.Generic;

#nullable disable

namespace pharmEasy.Models
{
    public partial class ProductImage
    {
        public int ProductImageId { get; set; }
        public string ImageUrl { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
