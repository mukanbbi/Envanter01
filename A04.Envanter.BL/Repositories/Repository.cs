using A02.Envanter.Entity;
using A03.Envanter.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace A04.Envanter.BL.Repositories
{
    public class Repository<T>:IRepository<T> where T:class, IEntity, new ()
    {
        private DatabaseContext context; //context tanımla
        private DbSet<T> dbSet;
        public Repository()
        {
            if (context==null)
            {
                context = new DatabaseContext();
                dbSet = context.Set<T>();
            }
        }

        public int Add(T entity)
        {
            dbSet.Add(entity);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            dbSet.Remove(Find(id));
            return Save();
        }

        public T Find(int id)
        {
            return dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return dbSet.FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression).ToList();
        }

        public IQueryable<T> GetAllByInclude(string table)
        {
            return dbSet.Include(table);
        }

        public IQueryable<T> GetAllByInclude4(string table, string table2, string table3, string table4)
        {
            return dbSet.Include(table4); ;
        }

        public int Update(T entity)
        {
            dbSet.AddOrUpdate(entity);
            return Save();
        }
        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
