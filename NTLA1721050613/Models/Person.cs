namespace NTLA1721050613.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [Key]
        [Required(ErrorMessage = "ID kh�ng ����c bo� tr��ng")]
        [StringLength(20)]
        public string PersonID { get; set; }

        [Required(ErrorMessage = "T�n kh�ng ����c bo� tr��ng")]
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}
