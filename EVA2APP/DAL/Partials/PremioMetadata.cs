using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PremioMetadata
    {
        [Required(ErrorMessage = "Campo Requerido")]
        [Range(1, 50, ErrorMessage = "El valor de {0} de estar entre {1} y {2}")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Range(2010, int.MaxValue, ErrorMessage = "El año tiene que ser mayor a {1}")]
        public string Anio { get; set; }
    }
}
