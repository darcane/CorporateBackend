﻿using System.Collections.Generic;
using Corp.AdventureWorks.Entities.Concrete;

namespace Corp.AdventureWorks.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        void TransactionalOperation(Product product1, Product product2);
    }
}