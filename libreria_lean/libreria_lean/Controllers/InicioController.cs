using Repository;
using Servicios.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace libreria_lean.Controllers
{
    public class InicioController : Controller
    {
        private LibreriaContext libreriaContext;

        public InicioController()
        {
            libreriaContext = new LibreriaContext();
        }

        // GET: Inicio
        public ActionResult Index()
        {
            List<product> productos = libreriaContext.product.ToList();
            ViewBag.Title = "Libreria";
            return View(productos);
        }

        // GET: Inicio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inicio/Create
        public ActionResult Create()
        {
            // Obtengo el maximo de valor de los id para dar uno más al producto nuevo
            var max_id = libreriaContext.product.Max(i => i.id_product);
            ViewBag.max_id = max_id + 1;
            return View();
        }

        // POST: Inicio/Create
        [HttpPost]
        public ActionResult Create(product producto_nuevo)
        {
           

            try
            {
                if (Request.Files.Count > 0 && Request.Files[0].ContentLength > 0)
                {
                    string nombreSignificativo = producto_nuevo.name;
                    //Guardar Imagen
                    string pathRelativoImagen = ImagenesUtility.Guardar(Request.Files[0], nombreSignificativo);
                    producto_nuevo.foto = pathRelativoImagen;
                }
                libreriaContext.product.Add(producto_nuevo);
                libreriaContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inicio/Edit/5
        public ActionResult Edit(int id)
        {
            /*var producto = libreriaContext.product.Find(id);

            producto.stock = 4;
            libreriaContext.SaveChanges();
            return RedirectToAction("Index");*/
            product producto = libreriaContext.product.Find(id);
            return View(producto);
        }

        // POST: Inicio/Edit/5
        [HttpPost]
        public ActionResult Edit(product producto_after)
        {
            try
            {
                product producto = libreriaContext.product.Find(producto_after.id_product);

                if (Request.Files.Count > 0 && Request.Files[0].ContentLength > 0)
                {
                    //TODO: Agregar validacion para confirmar que el archivo es una imagen
                    if (!string.IsNullOrEmpty(producto_after.foto))
                    {
                        //recordar eliminar la foto anterior si tenia
                        if (!string.IsNullOrEmpty(producto.foto))
                        {
                            ImagenesUtility.Borrar(producto_after.foto);
                        }

                        //creo un nombre significativo en este caso apellidonombre pero solo un caracter del nombre, ejemplo BatistutaG
                        string nombreSignificativo = producto_after.name;
                        //Guardar Imagen
                        string pathRelativoImagen = ImagenesUtility.Guardar(Request.Files[0], nombreSignificativo);
                        producto.foto = pathRelativoImagen;
                    }
                }
                
                producto.name = producto_after.name;
                producto.precio = producto_after.precio;
                producto.stock = producto_after.stock;
                producto.description_product = producto_after.description_product;

                libreriaContext.SaveChanges();
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inicio/Delete/5
        public ActionResult Delete(int id)
        {
            var producto = libreriaContext.product.Find(id);
            libreriaContext.product.Remove(producto);
            libreriaContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Inicio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
