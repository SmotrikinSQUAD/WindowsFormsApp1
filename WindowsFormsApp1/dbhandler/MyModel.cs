namespace WindowsFormsApp1.dbhandler
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<topic> topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<topic>()
                .Property(e => e.topic1)
                .IsUnicode(false);

            modelBuilder.Entity<topic>()
                .Property(e => e.words)
                .IsUnicode(false);
        }
    }
}
