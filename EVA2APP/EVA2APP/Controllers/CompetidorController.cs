using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EVA2APP.Controllers
{
    public class CompetidorController : Controller
    {
        private CompetidorServicio serviciocompetidor;
        
        public CompetidorController()
        {
            Context contexto = new Context();
            serviciocompetidor = new CompetidorServicio(contexto);
        }

        [HttpGet]
        public ActionResult ListaCompetidores()
        {
            List<Competidor> competidores = serviciocompetidor.ObtenerTodos();
            return View(competidores);
        }

        [HttpGet]
        public ActionResult AltaCompetidor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AltaCompetidor(Competidor competidor)
        {
            if (ModelState.IsValid)
            {
                serviciocompetidor.Alta(competidor);
                return RedirectToAction("ListaCompetidores");
            }
            else
            {
                return View(competidor);
            }
        }

        public ActionResult Eliminar(int id)
        {
            serviciocompetidor.EliminarCompetidor(id);
            return RedirectToAction("ListaCompetidores");
        }
    }
}