using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IRepository<T>
    {
        List<T> ObtenerTodos();
        void Alta(T entity);
        void Eliminar(int id);
        T ObtenerPorId(int id);
    }
}
