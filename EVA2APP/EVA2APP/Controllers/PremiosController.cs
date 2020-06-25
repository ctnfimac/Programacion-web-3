using DAL;
using DAL.ViewModels;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EVA2APP.Controllers
{
    public class PremiosController : Controller
    {
        private PremioServicio servicioPremio;
        private CompetidorServicio servicioCompetidor;

        public PremiosController()
        {
            Context contexto = new Context();
            servicioPremio = new PremioServicio(contexto);
            servicioCompetidor = new CompetidorServicio(contexto);
        }

        public ActionResult ListaPremios()
        {
            List<Premio> premios = servicioPremio.ObtenerTodos();
            return View(premios);
        }

        [HttpGet]
        public ActionResult AltaPremio()
        {
            PremioViewModel modelo = new PremioViewModel();
            modelo.competidores = servicioCompetidor.ObtenerTodos();
            return View(modelo);
        }

        [HttpPost]
        public ActionResult AltaPremio(Premio premio)
        {
            if (ModelState.IsValid)
            {
                servicioPremio.Alta(premio);
                return RedirectToAction("ListaPremios");
            }
            else
            {
                PremioViewModel modelo = new PremioViewModel();
                modelo.premio = premio;
                modelo.competidores = servicioCompetidor.ObtenerTodos();
                return View(modelo);
            }
        }

        public ActionResult Eliminar(int id)
        {
            servicioPremio.Eliminar(id);
            return RedirectToAction("ListaPremios");
        }

        /*private PremioServicio servicioPremio = new PremioServicio();
        private CompetidorServicio servicioCompetidores = new CompetidorServicio();
        // GET: Premios
        public ActionResult ListaPremios()
        {
            List<Premio> premios = servicioPremio.obtenerPremios();
            return View(premios);
        }

        [HttpGet]
        public ActionResult AltaPremio()
        {
            PremioViewModel modelo = new PremioViewModel();
            modelo.competidores = servicioCompetidores.obtenerCompetidores();
            return View(modelo);
        }

        [HttpPost]
        public ActionResult AltaPremio(Premio premio)
        {
            if (ModelState.IsValid)
            {
                servicioPremio.AltaPremio(premio);
                return RedirectToAction("ListaPremios");
            }
            else
            {
                PremioViewModel modelo = new PremioViewModel();
                modelo.premio = premio;
                modelo.competidores = servicioCompetidores.obtenerCompetidores();
                return View(modelo);
            }
        }*/
    }
}