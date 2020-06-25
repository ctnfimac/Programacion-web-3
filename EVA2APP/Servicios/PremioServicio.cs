﻿using DAL;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class PremioServicio: BaseRepository<Premio>
    {
        public PremioServicio(Context contexto) : base(contexto)
        {

        }
        /*private Context contexto;

        public PremioServicio()
        {
            contexto = new Context();
        }
        /*
        public List<Premio> obtenerPremios()
        {
            List<Premio> lista = new List<Premio>();
            try
            {
                lista = contexto.Premio.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return lista;
        }*/

        public void AltaPremio(Premio premio)
        {
            try
            {
                // Revizo si hay registrado los premios del competidor el mismo año
                if (yaEstaRegistrado(premio))
                {
                    Premio premioRegistrado = contexto.Premio.Where( o => o.IdCompetidor == premio.IdCompetidor && o.Anio == premio.Anio).FirstOrDefault();
                    premioRegistrado.Cantidad = premio.Cantidad;
                }
                else
                {
                    contexto.Premio.Add(premio);
                }
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private bool yaEstaRegistrado(Premio premio)
        {
            bool respuesta = false;
            var premioBuscado = from p in contexto.Premio
                                where p.Anio == premio.Anio && p.IdCompetidor == premio.IdCompetidor
                                select p;

            if (premioBuscado.Count() >= 1) respuesta = true;
         
            return respuesta;
        }


    }
}
