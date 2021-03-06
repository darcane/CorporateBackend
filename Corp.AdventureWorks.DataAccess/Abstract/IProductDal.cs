﻿using System.Collections.Generic;
using Corp.AdventureWorks.Entities.ComplexTypes;
using Corp.AdventureWorks.Entities.Concrete;
using Corp.Core.DataAccess;

namespace Corp.AdventureWorks.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}