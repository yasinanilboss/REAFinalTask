using Microsoft.EntityFrameworkCore;
using REAFinalTask.DataAccess.Abstract;
using REAFinalTask.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.DataAccess.Concrete
{
    public class Repo<T> : IRepo<T> where T : class
    {
        readonly Context con = new Context();
        readonly DbSet<T> obj;

        public Repo()
        {
            obj = con.Set<T>();
        }


        public int Add(T ent)
        {
            obj.Add(ent);
            return con.SaveChanges();
        }

        public int Delete(T ent)
        {
            obj.Remove(ent);
            return con.SaveChanges();
        }

        public T GetById(int id)
        {
            return obj.Find(id);
        }

        public List<T> ListAll(Expression<Func<T, bool>> filter = null)
        {
            return obj.ToList();
        }

        public int Update(T ent)
        {
            obj.Update(ent);
            return con.SaveChanges();
        }
    }


}
