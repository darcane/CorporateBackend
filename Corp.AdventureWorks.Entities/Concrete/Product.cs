using Corp.Core.Entities;

namespace Corp.AdventureWorks.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public decimal ListPrice { get; set; }
    }
}