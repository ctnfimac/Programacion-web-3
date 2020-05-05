using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica_Introducciona_Csharp
{
    class Program
    {
        enum Dias
        {
            Domingo = 1,
            Lunes = 2,
            Martes = 3,
            Miercoles = 4,
            Jueves = 5,
            Viernes = 6,
            Sabado = 7
        }

        enum Colores
        {
            blanco = 1,
            azul = 2,
            negro = 3
        }

        static void Main(string[] args)
        {
            string valor1 = "k";
            string valor2 = "5";

            Console.WriteLine("La suma es: {0}", suma(valor1, valor2));
            Console.WriteLine("La fecha actual es: {0}", obtenerFechaYhoraActual());
            Console.WriteLine((int)Dias.Domingo);
            Console.WriteLine("Generalidades Ejercicio2: {0}", cortarPalabra("Generalidades"));
            elegirColor(Colores.negro);
            enumeraciones2(Dias.Lunes);
            conversiones1();
            conversiones4();
            conversiones7();
            /*
             Comentario de bloque
             esto es un bloque
             */
            // comentario de linea
      
            Console.ReadKey();
        }

        

        private static void conversiones1()
        {
            bool miTrue = true;
            bool miFalse = false;
     
            Console.WriteLine(Convert.ToInt32(miTrue));
            Console.WriteLine(Convert.ToInt32(miFalse));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("false"));


            string[] values = { null, String.Empty, "True", "False",
                          "true", "false", "    true    ", "0",
                          "1", "-1", "string" };

            foreach (var value in values)
            {
                bool flag;
                if (Boolean.TryParse(value, out flag))
                    Console.WriteLine("'{0}' --> {1}", value, flag);
                else
                    Console.WriteLine("Unable to parse '{0}'.",
                                      value == null ? "<null>" : value);
            }
            
        }



        /// <summary>
        ///     Generalidades
        ///     Ejercicio1) Crear una función que devuelva la suma de dos números recibidos por parámetros
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns>String</returns>
        static string suma(string valor1, string valor2)
        {
            int resultado, val1, val2;

            if(!Int32.TryParse( valor1, out val1))
            {
                Console.WriteLine("el valor1 ingresado no es correcto");
                return "Error";
            }

            if(!Int32.TryParse(valor2, out val2))
            {
                Console.WriteLine("el valor2 ingresado no es correcto");
                return "Error";
            }

            resultado = val1 + val2;
            return resultado.ToString();
        }

        /// <summary>
        ///     Generalidades
        ///     Ejercicio 2) )Crear una función que reciba una cadena de 8 caracteres y 
        ///         retorne en el mismo parámetro la cadena cortada de izquierda a derecha 
        ///         en 4 caracteres.
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns>String</returns>
        static string cortarPalabra(string palabra)
        {
            return palabra.Substring(0,4);
        }

        /// <summary>
        ///   Generalidades  
        ///   Ejercicio 3)Crear una función que devuelva la fecha y hora actual
        /// </summary>
        /// <returns>string</returns>
        static string obtenerFechaYhoraActual()
        {
            DateTime fecha = DateTime.Now;
            return fecha.ToString();
        }

        /// <summary>
        ///     Enumeraciones
        ///     2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana
        /// </summary>
        /// <param name="dia"></param>
        private static void enumeraciones2(Dias dia)
        {
            Console.WriteLine(dia.ToString());
        }

        /// <summary>
        ///     Conversiones
        ///     ejercicio 3) Escriba una sentencia switch utilizando una enumeración con 3 colores
        ///     (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado.
        /// </summary>
        /// <param name="color"></param>
        static void elegirColor(Colores color)
        {
            switch (color)
            {
                case Colores.azul:
                    Console.WriteLine("Es el color Azul");
                    break;
                case Colores.blanco:
                    Console.WriteLine("Es el color Blanco");
                    break;
                case Colores.negro:
                    Console.WriteLine("Es el color Negro");
                    break;
                default:
                    Console.WriteLine("Color incorrecto");
                    break;
            }  
        }

        /// <summary>
        /// Ejercicio4-5)
        ///     Si se tiene una variable entera a, realice una sentencia if para evaluar si la 
        ///     variable a es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor 
        ///     es mayor a 10. 
        /// </summary>
        private static void conversiones4()
        {
            int a = 10;
            string msj = "";
            msj = a > 10 ? "El valor indicado es mayor a 10": "Error! El valor no es mayor a 10";
            Console.WriteLine(msj);
        }

        /// <summary>
        ///     Ejercicio7) Defina una variable a que en cada ciclo de una sentencia while 
        ///     incremente su valor en 5. Cuando la variable a exceda el valor de 50,
        ///     el ciclo while debe finalizar.
        /// </summary>
        private static void conversiones7()
        {
            int valor = 40;
            int iteraciones = 0;
            while(valor <= 50)
            {
                valor += 5;
                iteraciones++;
            }
            Console.WriteLine("El bucle realizo {0} iteraciones.", iteraciones);
        }
    }
}
