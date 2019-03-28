using Corp.AdventureWorks.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace Corp.AdventureWorks.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Schema(@"SalesLT");
            Table(@"Product");
            LazyLoad();
            Id(x => x.ProductId).Column(@"ProductId");
            Map(x => x.Name).Column(@"Name");
            Map(x => x.ProductCategoryId).Column(@"ProductCategoryId");
            Map(x => x.ProductNumber).Column(@"ProductNumber");
            Map(x => x.ListPrice).Column(@"ListPrice");

        }
    }
}