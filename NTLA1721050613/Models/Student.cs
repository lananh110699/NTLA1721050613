using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTLA1721050613.Models
{
    public class Student : Person
    {
        [StringLength(50)]
        [Display(Name = "Trường đại học")]
        public String University { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        public String Address { get; set; }
    }
}