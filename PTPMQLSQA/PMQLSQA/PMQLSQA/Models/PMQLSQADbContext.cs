using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{
    public partial class PMQLSQADbContext : DbContext
    {
        public PMQLSQADbContext() : base("name=PMQLSQADbContext")
        {

        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .Property(e => e.Username)
            .IsUnicode(false);
        }

    }
}