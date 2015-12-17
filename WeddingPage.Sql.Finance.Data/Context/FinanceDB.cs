using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommoProject.Models.Finance;


namespace WeddingPage.Sql.Finance.Data.Context
{
    public class FinanceDb : DbContext
    {
        public FinanceDb() : base("financeDB")
        {
        }

        public virtual IDbSet<Status> Statuses { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
