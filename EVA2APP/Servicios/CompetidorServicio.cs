﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class CompetidorServicio: BaseRepository<Competidor>
    {
        public CompetidorServicio(Context contexto) : base(contexto)
        {

        }

        public void EliminarCompetidor(int idCompetidor)
        {
            // buscar si hay algun premio relacionado con el competidor
            PremioServicio premioServicio = new PremioServicio(contexto);
            List<Premio> premiosTotales = premioServicio.ObtenerTodos();
            List<Premio> premiosDelCompeditor = premiosTotales.Where(o => o.IdCompetidor == idCompetidor).ToList();
            // si no hay lo elimino
            if(premiosDelCompeditor == null || premiosDelCompeditor.Count() == 0)
            {
                Eliminar(idCompetidor);
            }
            else
            {
                // si hay, busco todos los premios vinculados con el competidor y los elimino
                foreach  (Premio item in premiosDelCompeditor)
                {
                    premioServicio.Eliminar(item.IdPremio);
                }
                // luego elimino al competidor
                Eliminar(idCompetidor);
            }  
        }
    }
}
