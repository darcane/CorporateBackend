using System.Collections.Generic;
using System.Linq;
using Corp.AdventureWorks.DataAccess.Abstract;
using Corp.AdventureWorks.Entities.ComplexTypes;
using Corp.AdventureWorks.Entities.Concrete;
using Corp.Core.DataAccess.EntityFramework;

namespace Corp.AdventureWorks.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,AdventureWorksContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (var context = new AdventureWorksContext())
            {
                // LINQ expression of the method used below
                /* 
               var result = from p in context.Product
                    join c in context.Categories on p.ProductCategoryId equals c.ProductCategoryId
                    select new ProductDetail
                    {
                        ProductId = p.ProductId,
                        ProductName = p.Name,
                        CategoryName = c.Name
                    };
                 */
                var result = context.Product.Join(context.Categories, p => p.ProductCategoryId,
                    c => c.ProductCategoryId,
                    (p, c) => new ProductDetail {ProductId = p.ProductId, ProductName = p.Name, CategoryName = c.Name});
                return result.ToList();
            }
        }
    }
}