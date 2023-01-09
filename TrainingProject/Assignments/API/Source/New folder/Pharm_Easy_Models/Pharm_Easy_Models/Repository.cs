using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pharm_Easy_Models.Models;
using Pharm_Easy_Models.Services;
namespace Pharm_Easy_Models
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetCategories();
        Task<List<TEntity>> GetProducts();
        Task<List<TEntity>> GetOffers();
        Task<List<TEntity>> GetHarticle();
        Task<List<TEntity>> GetCarticle();

        void insertcategories(Categories categories);
        void insertproducts(Product product);
        void insertoffers(Offers offers);
        void insertHarticle(hArticle hArticle);
        void insertCarticle(CArticle cArticle);
      
        // void insertproduct(Product product);
    }
    public class Repository<T> : IRepository<T> where T : class
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

        public async Task<List<T>> GetCategories()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetProducts()
        {
            return await context.Set<T>().ToListAsync();
        }
        public async Task<List<T>> GetOffers()
        {
            return await context.Set<T>().ToListAsync();
        }
        public async Task<List<T>> GetHarticle()
        {
            return await context.Set<T>().ToListAsync();
        }
        public async Task<List<T>> GetCarticle()
        {
            return await context.Set<T>().ToListAsync();
        }
  
       
        public void insertcategories(Categories categories)
        {
            try
            {
                Categories categories1 = new Categories();
                categories1.Cat_Name = categories.Cat_Name;
                context.Categories.Add(categories1);
                context.SaveChanges();
            }
            catch (Exception e){}
         }
        public void insertproducts(Product product)
        {
            try
            {
                Product product1 = new Product();
                product1.Pr_Name = product.Pr_Name;
                product1.Pr_Discription = product.Pr_Discription;
                product1.Pr_Price = product.Pr_Price;
                product1.Cat_Id = product.Cat_Id;
                context.products.Add(product1);
                context.SaveChanges();
            }
            catch (Exception e) { }
        }
        public void insertoffers(Offers offers)
        {
            try
            {
                Offers offers1 = new Offers();
                offers1.Off_Discription = offers.Off_Discription;
                offers1.Off_Code = offers.Off_Code;
                context.offers.Add(offers1);
                context.SaveChanges();
            }
            catch (Exception e) { }
        }
        public void insertHarticle(hArticle hArticle)
        {
            try
            {
                hArticle hArticle1 = new hArticle();
                hArticle1.H_Heading = hArticle.H_Heading;
                hArticle1.H_Discription = hArticle.H_Discription;
                context.hArticles.Add(hArticle1);
                context.SaveChanges();
            }
            catch(Exception e) { }
        }
        public void insertCarticle(CArticle cArticle)
        {
            try
            {
                CArticle cArticle1 = new CArticle();
                cArticle1.C_Name = cArticle.C_Name;
                cArticle1.A_Date = cArticle.A_Date;
                cArticle1.A_Discription = cArticle.A_Discription;
                context.cArticles.Add(cArticle1);
                context.SaveChanges();
            }
            catch (Exception e) { }
        }
        //public void insertHarticle(hArticle hArticle)
        // {
        //     throw new NotImplementedException();
        // }


    }
}
