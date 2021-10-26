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
        [Required(ErrorMessage = "ID không ðýõòc boÒ trôìng")]
        [StringLength(20)]
        [Display(Name = "ID sinh viên")]
        public string PersonID { get; set; }

        [Required(ErrorMessage = "Tên không ðýõòc boÒ trôìng")]
        [StringLength(50)]
        [Display(Name = "Tên sinh viên")]
        public string PersonName { get; set; }
    }
}
