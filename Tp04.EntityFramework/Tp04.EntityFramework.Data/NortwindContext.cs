using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Tp04.EntityFramework.Entities;

namespace Tp04.EntityFramework.Data
{
    public partial class NortwindContext : DbContext
    {
        public NortwindContext()
            : base("name=NortwindConnection")
        {
        }

        public virtual DbSet<Shippers> Shippers { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
