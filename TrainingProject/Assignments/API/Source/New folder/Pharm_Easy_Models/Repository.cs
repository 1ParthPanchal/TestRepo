using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pharm_Easy_Models.Models;
using Pharm_Easy_Models.Migrations;
namespace Pharm_Easy_Models
{
    public interface IRepository : IDisposable
    {
        IEnumerable<Categories> GetCategories();
        void insertcategories(Categories categories);


    }
    public class Repository : IRepository , IDisposable
    {
        public Context context;
        public Repository(Context context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categories> GetCategories()
        {
            return context.Categories.ToList();
            //context.SaveChanges();
        }
        public void insertcategories(Categories categories)
        {
             context.Categories.Add(categories);
        
        }
        //public T Post(T entity)
        //{
        //    context.Add(entity);
        //    context.SaveChanges();
        //    return entity;
        //}
        //public List<T> Get()
        //{
        //    return context.Set<T>().ToList();
        //}
    }
}
