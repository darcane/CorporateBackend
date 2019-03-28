using System;
using Corp.Core.Entities;

namespace Corp.AdventureWorks.Entities.Concrete
{
    public class ProductCategory : IEntity
    {
        public int ProductCategoryId { get; set; }
        public int ParentProductCategoryId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}