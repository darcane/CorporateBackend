using System;
using System.Collections.Generic;
using System.Transactions;
using Corp.AdventureWorks.Business.Abstract;
using Corp.AdventureWorks.Business.ValidationRules.FluentValidation;
using Corp.AdventureWorks.DataAccess.Abstract;
using Corp.AdventureWorks.Entities.Concrete;
using Corp.Core.Aspects.PostSharp;
using Corp.Core.Aspects.PostSharp.TransactionAspects;
using Corp.Core.Aspects.PostSharp.ValidationAspects;

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

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            // Business logic here
            _productDal.Update(product2);
        }
    }
}