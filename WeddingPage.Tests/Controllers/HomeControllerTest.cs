using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeddingPage;
using WeddingPage.Controllers;
using Moq;
using CommonProject.Interfaces;
using CommoProject.Interfaces;
using CommoProject.Models;
using CommoProject.Models.Finance;

namespace WeddingPage.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IRepository<Status>> _repo;

        [TestMethod]
        public void Index()
        {
            // Arrange
            _repo = new Mock<IRepository<Status>>();
            HomeController controller = new HomeController(_repo.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            _repo = new Mock<IRepository<Status>>();
            HomeController controller = new HomeController(_repo.Object);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            _repo = new Mock<IRepository<Status>>();
            HomeController controller = new HomeController(_repo.Object);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
