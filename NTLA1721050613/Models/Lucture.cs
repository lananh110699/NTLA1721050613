using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTLA1721050613.Models
{
    public class Lucture : Person
    {
        
        [StringLength(50)]
        [Display(Name = "Khoa")]
        public String Faculty { get; set; }

        [StringLength(50)]
        [Display(Name = "Bộ môn")]
        public String Department { get; set; }
    }
    
}