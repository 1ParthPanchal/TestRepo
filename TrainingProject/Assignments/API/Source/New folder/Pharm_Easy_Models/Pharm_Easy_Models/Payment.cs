using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pharm_Easy_Models.Models
{
    public class payment
    {
        [Key]
        public int p_id { get; set; }
        public string p_method { get; set; }

    }
}
