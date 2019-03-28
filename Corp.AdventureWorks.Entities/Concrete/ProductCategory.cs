using System;
using Corp.Core.Entities;

namespace Corp.AdventureWorks.Entities.Concrete
{
    public class ProductCategory : IEntity
    {
        public virtual int ProductCategoryId { get; set; }
        public virtual int ParentProductCategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}