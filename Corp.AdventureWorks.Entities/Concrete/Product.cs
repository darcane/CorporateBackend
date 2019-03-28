using Corp.Core.Entities;

namespace Corp.AdventureWorks.Entities.Concrete
{
    public class Product : IEntity
    {
        public virtual int ProductId { get; set; }
        public virtual int ProductCategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual string ProductNumber { get; set; }
        public virtual decimal ListPrice { get; set; }
    }
}