using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuiaPractica_Introductorio_ASPNET_MVC.Models;
using Models;
using Servicios;

namespace GuiaPractica_Introductorio_ASPNET_MVC.Controllers
{
    public class ProductosController : Controller
    {
        private ProductoServicio ServicioProducto = new ProductoServicio();
        // GET: Productos
        public ActionResult ListaDeProductos()
        {
            List<Producto> Productos = ServicioProducto.ListaDeProductos();
            return View(Productos);
        }

        public ActionResult AgregarProducto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarProducto(Producto ProductoNuevo)
        {
            ServicioProducto.AgregarProducto(ProductoNuevo);
            return RedirectToAction("ListaDeProductos");
        }

        public ActionResult EliminarProducto(int Id)
        {
            ServicioProducto.EliminarProducto(Id);
            return RedirectToAction("ListaDeProductos");
        }

        public ActionResult ModificarProducto(int Id)
        {
            Producto producto = ServicioProducto.BuscarProducto(Id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult ModificarProducto(Producto producto)
        {
            ServicioProducto.ModificarProducto(producto);
            return RedirectToAction("ListaDeProductos");
        }

        // con ViewModel
        private ProductoViewModel ProductoViewModelAlta()
        {
            List<TipoDeProducto> tipos = new List<TipoDeProducto>() {
                new TipoDeProducto(1,"Libreria"),
                new TipoDeProducto(2,"Hogar"),
                new TipoDeProducto(3,"Tecnología"),
                new TipoDeProducto(4,"Deportes")
            };
            ProductoViewModel model = new ProductoViewModel();
            model.tipo = tipos;
            return model;
        }

        [HttpGet]
        public ActionResult AgregarProductoVm()
        {
            var model = ProductoViewModelAlta();
            return View(model);
        }

        public ActionResult ModificarProductoVM(int Id)
        {
            ProductoViewModel model = new ProductoViewModel();
            Producto producto = ServicioProducto.BuscarProducto(Id);
            List<TipoDeProducto> tipos = new List<TipoDeProducto>() {
                new TipoDeProducto(1,"Libreria"),
                new TipoDeProducto(2,"Hogar"),
                new TipoDeProducto(3,"Tecnología"),
                new TipoDeProducto(4,"Deportes")
            };
            model.producto = producto;
            model.tipo = tipos;
            return View(model);
        }

        [HttpPost]
        public ActionResult ModificarProductoVM(Producto producto)
        {
            ServicioProducto.ModificarProducto(producto);
            return RedirectToAction("ListaDeProductos");
        }
    }
}