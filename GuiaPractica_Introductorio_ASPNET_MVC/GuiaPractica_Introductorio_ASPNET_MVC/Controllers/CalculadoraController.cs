using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aritmetica;

namespace GuiaPractica_Introductorio_ASPNET_MVC.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Operacion()
        {
            ViewBag.Resultado = "0";
            return View();
        }

        [HttpPost]
        public ActionResult Operacion(FormCollection form)
        {
            string valor1 = Convert.ToString(form["operador1"]);
            string valor2 = form["operador2"];
            string operacion = Convert.ToString(form["operacion"]);
            string respuesta = "";
            switch (operacion)
            {
                case "sumar":
                    respuesta = Aritmetica.Operacion.Sumar(valor1, valor2);
                    break;
                case "restar":
                    respuesta = Aritmetica.Operacion.Restar(valor1, valor2);
                    break;
                case "multiplicar":
                    respuesta = Aritmetica.Operacion.Multiplicar(valor1, valor2);
                    break;
                case "dividir":
                    respuesta = Aritmetica.Operacion.Dividir(valor1, valor2);
                    break;
                default:
                    respuesta = "Error";
                    break;
            }
            ViewBag.Resultado = respuesta;
            
            return View();
        }
    }
}