using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Servicios
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected Context contexto { set; get; }
        protected DbSet<T> dbSet;

        public BaseRepository(Context ctx)
        {
            contexto = ctx;
            dbSet = ctx.Set<T>();
        }

        public List<T> ObtenerTodos()
        {
            return dbSet.ToList();
        }

        public void Alta(T entity)
        {
            dbSet.Add(entity);
            SaveChanges(contexto);
        }

        public void Eliminar(int id)
        {
            T entidad = ObtenerPorId(id);
            if(entidad != null)
            {
                dbSet.Remove(entidad);
                SaveChanges(contexto);
            }
        }

        public T ObtenerPorId(int id)
        {
            return dbSet.Find(id);
        }

        protected void SaveChanges(Context contexto)
        {
            try
            {
                contexto.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
