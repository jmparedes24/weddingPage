using CommonProject.Interfaces;
using CommoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommoProject.Interfaces;

namespace WeddingPage.Sql.Repository
{
    public class GuestRepository : IRepository<Guest>
    {
        #region Private

        private WeddingDBContext _dbcontext;

        #endregion

        #region Constructor

        public GuestRepository(WeddingDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        #endregion
        #region Methods
        public IEnumerable<Guest> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Guest entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guest entity)
        {
            throw new NotImplementedException();
        }

        public Guest FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guest entity)
        {
            throw new NotImplementedException();
        } 

        #endregion
    }
}
