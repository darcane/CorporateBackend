using System.Collections.Generic;
using Corp.AdventureWorks.Business.Abstract;
using Corp.AdventureWorks.DataAccess.Abstract;
using Corp.AdventureWorks.Entities.Concrete;

namespace Corp.AdventureWorks.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
    }
}