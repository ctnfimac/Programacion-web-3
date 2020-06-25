using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class PremioViewModel
    {
        public Premio premio { set; get; }
        public List<Competidor> competidores { set; get; }
    }
}
