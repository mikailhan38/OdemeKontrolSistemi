using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;
        public Repository()
        {
            _object=context.Set<T>();
        }
        public int delete(T p)
        {
            _object.Remove(p);
            return context.SaveChanges();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(T p)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public int update(T p)
        {
            throw new NotImplementedException();
        }
    }
}
