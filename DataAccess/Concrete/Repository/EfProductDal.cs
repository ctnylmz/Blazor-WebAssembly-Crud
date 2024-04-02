using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Entities.Dto;
using Shareds.DataAcces.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repository
{
    public class EfProductDal : EfEntityRepositoryBase<Product, QrKitchenContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using (QrKitchenContext context = new QrKitchenContext())
            {
                var result = from p in context.Products
                             join c in context.Categorys
                                 on p.CategoryId equals c.Id
                             select new ProductDetailDto
                             {
                                 Id = p.Id,
                                 CategoryId = c.Id,
                                 CategoryName = c.Name,
                                 Name = p.Name,
                                 Description = p.Description,
                                 Price = p.Price,
                                 ImageUrl = p.ImageUrl,
                                 Status = p.Status,
                             };
                return filter == null
                ? result.ToList()
                : result.Where(filter).ToList();

            }
        }
    }
}
