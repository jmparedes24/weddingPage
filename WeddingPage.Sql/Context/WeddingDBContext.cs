using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using CommoProject.Models;

namespace WeddingPage.Sql
{
    public partial class WeddingDBContext : DbContext
    {
        public WeddingDBContext() : base("weddingDB") { }

        public DbSet<Guest> Guests;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");
        }
    }
}
