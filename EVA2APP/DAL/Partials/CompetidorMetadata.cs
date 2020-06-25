using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CompetidorMetadata
    {
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(100, ErrorMessage = "No puede tener mas de 100 caracteres")]
        public string Nombre { get; set; }
    }
}
