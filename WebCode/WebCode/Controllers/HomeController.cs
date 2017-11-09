using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCode.Controllers
{
    public class HomeController : Controller
    {
        List<MenuItem> mainMenu = new List<MenuItem>();
        List<MenuItem> childMenu = new List<MenuItem>();

        public HomeController()
        {
            mainMenu = new List<MenuItem>()
            {
                new MenuItem() { id = 1, name = "Home", action = "Index", parentId = null},
                new MenuItem() { id = 2, name = "About", action = "About", parentId = null},
                new MenuItem() { id = 3, name = "Events", action = "EventDetail", parentId = null},
                new MenuItem() { id = 4, name = "Gallery", action = "", parentId = null},
                new MenuItem() { id = 5, name = "Causes", action = "", parentId = null},
                new MenuItem() { id = 6, name = "Page", action = "", parentId = null},
                new MenuItem() { id = 7, name = "Blog", action = "", parentId = null},
                new MenuItem() { id = 8, name = "Contact", action = "Contact", parentId = null}
            };

            childMenu = new List<MenuItem>()
            {
                new MenuItem() { id = 9, name = "About us one", action = "About", parentId = 2},
                new MenuItem() { id = 10, name = "About us two", action = "", parentId = 2},
                new MenuItem() { id = 11, name = "Event details", action = "EventDetails", parentId = 3},
                new MenuItem() { id = 12, name = "Gallery one", action = "", parentId = 4},
                new MenuItem() { id = 13, name = "Gallery two", action = "", parentId = 4},
                new MenuItem() { id = 15, name = "Gallery three", action = "", parentId = 4},
                new MenuItem() { id = 16, name = "Gallery four", action = "", parentId = 4},
                new MenuItem() { id = 17, name = "Cause details one", action = "", parentId = 5},
                new MenuItem() { id = 18, name = "Cause details two", action = "", parentId = 5},
                new MenuItem() { id = 18, name = "Staff page", action = "", parentId = 6},
                new MenuItem() { id = 18, name = "Staff profile", action = "", parentId = 6},
                new MenuItem() { id = 18, name = "Staff profile two", action = "", parentId = 6},
                new MenuItem() { id = 18, name = "Donation", action = "", parentId = 6},
                new MenuItem() { id = 18, name = "Faq", action = "", parentId = 6},
                new MenuItem() { id = 18, name = "Error-404", action = "", parentId = 6},
                new MenuItem() { id = 18, name = "Blog one", action = "BlogV1", parentId = 7},
                new MenuItem() { id = 18, name = "Blog two", action = "", parentId = 7},
                new MenuItem() { id = 18, name = "Blog three", action = "", parentId = 7},
                new MenuItem() { id = 18, name = "Blog details", action = "", parentId = 7}
            };
        }

        public ActionResult Index()
        {       
            HomeItem home = new HomeItem();
            home.menuitem = mainMenu;
            home.childitem = childMenu;
            return View(home);
        }

        [HttpGet]
        public ActionResult Index2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            HomeItem home = new HomeItem();
            home.menuitem = mainMenu;
            home.childitem = childMenu;
            return View(home);
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult EventDetails()
        {
            HomeItem home = new HomeItem();
            home.menuitem = mainMenu;
            home.childitem = childMenu;

            return View(home);
        }

        [HttpGet]
        public ActionResult BlogV1()
        {
            HomeItem home = new HomeItem();
            home.menuitem = mainMenu;
            home.childitem = childMenu;

            return View(home);
        }

        [HttpGet]
        public ActionResult _MenuPartial()
        {
            HomeItem home = new HomeItem();
            home.menuitem = mainMenu;
            home.childitem = childMenu;
            return View(home);
        }
    }

    public class HomeItem
    {
        public List<MenuItem> menuitem { get; set; }
        public List<MenuItem> childitem { get; set; }
    }

    public class MenuItem
    {
        public int id{ get; set; }
        public string name { get; set; }
        public string action { get; set; }
        public int? parentId { get; set; }
    }
}