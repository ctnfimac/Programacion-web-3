using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace GuiaPractica_Introductorio_ASPNET_MVC.Controllers
{
    public class EncuestasController : Controller
    {
        // GET: Encuestas
        public ActionResult Encuesta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MostrarEncuesta(FormCollection form)
        {
            string nombre = Convert.ToString(form["nombre"]);
            string descripcion = Convert.ToString(form["descripcion"]);
            string deacuerdo = Convert.ToString(form["deacuerdo"]);
            ViewBag.Nombre = nombre;
            ViewBag.Descripcion = descripcion;
            ViewBag.Deacuerdo = deacuerdo;
            return View();
        }

        [HttpGet]
        public ActionResult EncuestaModel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearEncuesta(Encuesta encuesta)
        {
            return View(encuesta);
        }


    }
}