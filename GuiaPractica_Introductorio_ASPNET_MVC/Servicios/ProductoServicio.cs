using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Servicios
{
    public class ProductoServicio
    {
        private static List<Producto> Productos = new List<Producto>();

        public List<Producto> ListaDeProductos()
        {
            return Productos;
        }

        
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void EliminarProducto(int id)
        {
            Productos.RemoveAll(p => p.Id == id); 
        }

        public Producto BuscarProducto(int id)
        {
            Producto producto = Productos.Find(p => p.Id == id);
            return producto;
        }

        public void ModificarProducto(Producto productoAModificar)
        {
            Producto producto = BuscarProducto(productoAModificar.Id);
            producto.Nombre = productoAModificar.Nombre;
            producto.Cantidad = productoAModificar.Cantidad;
            producto.Precio = productoAModificar.Precio;
            producto.FechaAlta = productoAModificar.FechaAlta;
            producto.Tipo = productoAModificar.Tipo;
        }

    }
}
