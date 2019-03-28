using System.Collections.Generic;
using System.Linq;
using Corp.AdventureWorks.DataAccess.Abstract;
using Corp.AdventureWorks.Entities.ComplexTypes;
using Corp.AdventureWorks.Entities.Concrete;
using Corp.Core.DataAccess.NHibernate;

namespace Corp.AdventureWorks.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private readonly NHibernateHelper _nHibernateHelper;

        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                // LINQ expression of the method used below
                /*
                var result = from p in session.Query<Product>()
                    join c in session.Query<ProductCategory>() on p.ProductCategoryId equals c.ProductCategoryId
                    select new ProductDetail
                    {
                        ProductId = p.ProductId,
                        ProductName = p.Name,
                        CategoryName = c.Name
                    };
                 */
                var result = session.Query<Product>()
                    .Join(session.Query<ProductCategory>(), p => p.ProductCategoryId, c => c.ProductCategoryId,
                        (p, c) => new ProductDetail
                        {
                            ProductId = p.ProductId, ProductName = p.Name, CategoryName = c.Name
                        });

                return result.ToList();
            }
        }
    }
}