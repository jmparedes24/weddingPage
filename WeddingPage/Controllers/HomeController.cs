using CommonProject.Interfaces;
using CommoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommoProject.Interfaces;
using CommoProject.Models.Finance;

namespace WeddingPage.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Status> _repo;

        public HomeController(IRepository<Status> repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            var myestatus = _repo.FindById(1);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}