using DawgInHim.DataAccess.Repository.IRepository;
using DawgInHim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DawgInHim.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = objFromDb.Title;
                objFromDb.Description = objFromDb.Description;
                objFromDb.Price = objFromDb.Price;
                objFromDb.ISBN = objFromDb.ISBN;
                objFromDb.Author = objFromDb.Author;
                objFromDb.CategoryId = objFromDb.CategoryId;
                objFromDb.CoverTypeId = objFromDb.CoverTypeId;
                objFromDb.ListPrice = objFromDb.ListPrice;
                objFromDb.Price50 = objFromDb.Price50;
                objFromDb.Price100 = objFromDb.Price100;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }

            }
        }
    }
}