using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace EVA2APP.Controllers
{
    public class CantidadTotalPremiosApiController : ApiController
    {
        private PremioServicio servicioPremio;
        public CantidadTotalPremiosApiController()
        {
            Context contexto = new Context();
            servicioPremio = new PremioServicio(contexto);

        }
        // GET api/values/anio 
        public IEnumerable<string> Get(int id)
        {
            /*var lista = contexto.Premio.Where(o => o.Anio == id.ToString()).ToList();
            string cantidad = lista.Count().ToString();
            return new string[] { "En el " + id.ToString() + " hubieron " + cantidad + " premios totales" };*/
            return servicioPremio.cantidadDePremiosPorAnio(id);
        }
    }
}
