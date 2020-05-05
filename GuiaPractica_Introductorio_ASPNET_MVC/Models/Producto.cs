using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{  
    public class Producto
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public int Cantidad { set; get; }
        public decimal Precio { set; get; }
        public DateTime FechaAlta { set; get; }

        public int Tipo { set; get; }
    }

}
