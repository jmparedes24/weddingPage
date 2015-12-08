using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonProject.Interfaces;
using CommoProject.Models.Finance;
using WeddingPage.Sql.Finance.Data.Context;

namespace WeddingPage.Sql.Finance.Data.Repository
{
    public class StatusRepository : IRepository<Status>
    {
        private FinanceDb _context;

        public StatusRepository(FinanceDb context)
        {
            _context = context;
        }

        public IEnumerable<Status> List { get; }
        public void Add(Status entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Status entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Status entity)
        {
            throw new NotImplementedException();
        }

        public Status FindById(int Id)
        {
            return _context.Statuses.FirstOrDefault(x => x.StatusId == Id);
        }
    }
}
