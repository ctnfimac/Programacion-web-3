using DAL;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class CantidadTotalPremiosApiController : ApiController
    {
        private Context contexto;

        public CantidadTotalPremiosApiController()
        {
            contexto = new Context();
        }
        // GET api/values/5
        public IEnumerable<string> Get(int id)
        {
            var lista = contexto.Premio.Where( o => o.Anio == id.ToString()).ToList();
            string cantidad = lista.Count().ToString();
            return new string[] { "En el " +id.ToString()+ " hubieron " + cantidad + " premios totales" };
        }

      
    }
}