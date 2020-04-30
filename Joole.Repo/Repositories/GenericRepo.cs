using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;
using System.Data.Entity;

namespace Joole.Repo.Repositories
{
    public class GenericRepo<T> where T: class
    {
        DbSet<T> _entity;
        //JooleDataContext _jooleDataContext;

        public GenericRepo (JooleDataContext context)
        {
            _entity = context.Set<T>();
            //_jooleDataContext = context;
        }

        public void Add(T t)
        {
            _entity.Add(t);
            //_jooleDataContext.Set<T>().Add(t);
            //_jooleDataContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.AsEnumerable();
        }

    }
}
