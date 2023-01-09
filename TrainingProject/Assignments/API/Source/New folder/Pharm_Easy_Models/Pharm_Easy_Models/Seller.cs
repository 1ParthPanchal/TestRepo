using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Pharm_Easy_Models.Models;

namespace Pharm_Easy_Models.Models
{
    public class Seller
    {
    }
    public class login
    {
        [Key]
        public int Mobile_Number { get; set; }
        public string Create_Password { get; set; }
        public string Conform_Password { get; set; }

        public string GST_Number { get; set; }
    }
    public class DisplayDetails
    {
        [Key]
        public string Full_Name { get; set; }
        public string Display_Name { get; set; }
        public int Pincode { get; set; }
    }
    public class SellerCatagories
    {
        [Key]
        public int Cat_Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Cat_Name { get; set; }
    }
    public class SProduct
    {
        [Key]
        public int Pr_Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Pr_Name { get; set; }
        public string Pr_Discription { get; set; }
        public int Pr_Price { get; set; }
        public virtual SellerCatagories Cat_Id { get; set; }
        public string Brand_Name { get; set; }
    }
}
