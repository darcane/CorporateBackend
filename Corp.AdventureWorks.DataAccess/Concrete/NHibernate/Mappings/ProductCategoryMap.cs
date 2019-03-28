using Corp.AdventureWorks.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace Corp.AdventureWorks.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductCategoryMap: ClassMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            Schema(@"SalesLT");
            Table(@"ProductCategory");
            LazyLoad();
            Id(x => x.ProductCategoryId).Column(@"ProductCategoryId");
            Map(x => x.ParentProductCategoryId).Column(@"ParentProductCategoryId");
            Map(x => x.Name).Column(@"Name");
            Map(x => x.ModifiedDate).Column(@"ModifiedDate");
        }
    }
}