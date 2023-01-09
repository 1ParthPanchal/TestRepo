using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pharmEasy.Models;
namespace pharmEasy
{
    public interface IRepository : IDisposable
    {
        IEnumerable<Category> GetCategories();
        void insertcategories(Category categories);
        void deletecategories(int CategoryId);
        void updatecategories(Category categories);

    }
    public class Repository : IRepository, IDisposable
    {
        public pharmeasy2443parthContext context;
        public Repository(pharmeasy2443parthContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
       

     

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public void insertcategories(Category categories)
        {
            try
            {
                Category category1 = new Category();
                category1.CategoryId = categories.CategoryId;
                category1.CategoryName = categories.CategoryName;
                category1.ParentCategory = categories.ParentCategory;
                category1.Description = categories.Description;
            }
            catch(Exception e)
            { }
        }

        public void updatecategories(Category categories)
        {
            context.Entry(categories).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void deletecategories(int CategoryId)
        {
            Category category = context.Categories.Find(CategoryId);
            context.Categories.Remove(category);
        }
    }
}
