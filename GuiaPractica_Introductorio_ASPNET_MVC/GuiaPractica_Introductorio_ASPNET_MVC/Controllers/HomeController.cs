using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuiaPractica_Introductorio_ASPNET_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Formulario(string nombre = "Christian")
        {
            ViewBag.Nombre = nombre;
            return View("Formulario");
        }
    }
}