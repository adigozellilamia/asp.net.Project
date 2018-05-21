using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        CvEntities2 db = new CvEntities2();
        public ActionResult Index()
        {
            ViewBag.Abouts = db.Abouts.ToList();
            
            
            ViewBag.Skills_icon = db.Icons.Where(w => w.Page == "Skills").ToList();
            ViewBag.Skills_list = db.Lists.Where(w => w.Page == "Skills").ToList();
            ViewBag.Awards_list = db.Lists.Where(w => w.Page == "Awards").ToList();
            ViewBag.Experience_text = db.Texts.Where(w => w.Page == "Experience").ToList();
            ViewBag.Educatione_text = db.Texts.Where(w => w.Page == "Education").ToList();
            ViewBag.Interests_text = db.Texts.Where(w => w.Page == "Interests").ToList();
            return View();
        }

        

    }
}