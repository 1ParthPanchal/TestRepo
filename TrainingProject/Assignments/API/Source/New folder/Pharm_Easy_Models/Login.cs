using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Pharm_Easy_Models.Models;
namespace Pharm_Easy_Models.Models
{
    public class Login

    {
        [Key]
        public int MobileNumber { get; set; }
       
    }
}
