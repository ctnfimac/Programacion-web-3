using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetica
{
    public class Operacion
    {
        public static string Sumar(string valor1, string valor2)
        {
            string resultado = "Error";
            try
            {
                int suma = int.Parse(valor1) + int.Parse(valor2);
                resultado = suma.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Error con la suma");
            }
            return resultado;
        }

        public static string Restar(string valor1, string valor2)
        {
            string resultado = "Error";
            try
            {
                int resta = int.Parse(valor1) - int.Parse(valor2);
                resultado = resta.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Error con la resta");
            }
            return resultado;
        }

        public static string Multiplicar(string valor1, string valor2)
        {
            string resultado = "Error";
            try
            {
                int multiplicar = int.Parse(valor1) * int.Parse(valor2);
                resultado = multiplicar.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Error con la resta");
            }
            return resultado;
        }

        public static string Dividir(string valor1, string valor2)
        {
            string resultado = "Error";
            try
            {
                int dividir = int.Parse(valor1) / int.Parse(valor2);
                resultado = dividir.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Error con la resta");
            }
            return resultado;
        }
    }
}
