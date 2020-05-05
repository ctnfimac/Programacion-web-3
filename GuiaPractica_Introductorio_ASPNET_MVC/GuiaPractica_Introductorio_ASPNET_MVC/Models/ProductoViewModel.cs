using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace GuiaPractica_Introductorio_ASPNET_MVC.Models
{
    public class ProductoViewModel
    {
        public Producto producto { set; get; }
        public List<TipoDeProducto> tipo { set; get; }
    }
}