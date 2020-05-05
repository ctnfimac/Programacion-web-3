using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TipoDeProducto
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }

        public TipoDeProducto(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
    }
}
