
using CommoProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System.Data.Entity;
using System.Web.Mvc;
using CommonProject.Interfaces;
using CommoProject.Interfaces;
using CommoProject.Models.Finance;
using WeddingPage.Controllers;
using WeddingPage.Identity.Sql.Data.Context;
using WeddingPage.Sql.Finance.Data.Context;
using WeddingPage.Sql.Finance.Data.Repository;
using WeddingPage.Sql.Repository;

namespace WeddingPage
{
    public class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            
            container.RegisterType<IController, HomeController>();
            
            container.RegisterType<IController, ManageController>();

            //Repositories
            container.RegisterType<IRepository<Guest>, GuestRepository>();
            container.RegisterType<IRepository<Status>, StatusRepository>();

            //DataBase context
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            //container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());            

            container.RegisterType<DbContext, FinanceDb>(new PerRequestLifetimeManager());

            //Controllers
            container.RegisterType<AccountController>(new InjectionConstructor());

            return container;
        }

    }
}
