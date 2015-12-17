using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CommoProject.Models.Finance;
using Moq;
using NUnit.Framework;
using WeddingPage.Sql.Finance.Data.Context;
using WeddingPage.Sql.Finance.Data.Repository;

namespace WeddingPage.Sql.Finance.Data.Test
{
    [TestFixture]
    public class StatusReposuitoryTest
    {
        private Mock<FinanceDb> _context;
        private Mock<IDbSet<Status>> _statutsDbSet;
        


        [SetUp]
        public void Init()
        {
            

            
        }

        [Test]
        public void FindById()
        {
            //Arrange
            var statusexpected = new Status() { StatusId = 1, Active = true, Description = "Active" };
            var statuses = new List<Status>
            {
                new Status { StatusId = 1, Active = true, Description = "Active"},
                new Status { StatusId = 2, Active = true, Description = "Inactive"},
            }.AsQueryable();


            _statutsDbSet = new Mock<IDbSet<Status>>();

            _statutsDbSet.As<IQueryable<Status>>()
                .Setup(m => m.Provider)
                .Returns(statuses.Provider);

            _statutsDbSet.As<IQueryable<Status>>().Setup(m => m.Expression).Returns(statuses.Expression);
            _statutsDbSet.As<IQueryable<Status>>().Setup(m => m.ElementType).Returns(statuses.ElementType);
            _statutsDbSet.As<IQueryable<Status>>().Setup(m => m.GetEnumerator()).Returns(statuses.GetEnumerator());
            _context = new Mock<FinanceDb>();
            _context.Setup(c => c.Statuses).Returns(_statutsDbSet.Object);

            //Act
            var statusrepository = new StatusRepository(_context.Object);

            var status =  statusrepository.FindById(1);

            Assert.IsNotNull(status);
            Assert.AreEqual(statusexpected.StatusId, status.StatusId);
            Assert.AreEqual(statusexpected.Description, status.Description);
        }
    }
}
