using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTLA1721050613.Models
{
    public partial class NTLA1721050613DBContext : DbContext
    {
        public NTLA1721050613DBContext()
            : base("name=NTLA1721050613DBContext")
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lucture> Luctures{ get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.PersonID)
                .IsUnicode(false);
        }
    }
}
