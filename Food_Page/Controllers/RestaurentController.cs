using Food_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Food_Page.Controllers
{
    public class RestaurentController : Controller
    {
        // GET: Restaurent
        public ActionResult GetMenuDetails()
        {
            MVC_PAGEEntities mVC_PAGEEntities = new MVC_PAGEEntities();
            List<Restaurent> restaurents =  mVC_PAGEEntities.Restaurents.ToList();
            return View(restaurents);
        }
        public ActionResult GetItemBySno(int Sno)
        {
            MVC_PAGEEntities mVC_PAGEEntities = new MVC_PAGEEntities();
            var restaurent = mVC_PAGEEntities.Restaurents.Find(Sno);
            return View(restaurent); 
        }
        public ActionResult ItemDetails()
        {
            return View();

        }
    }
}