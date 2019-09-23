using System.Data.Entity.ModelConfiguration;
using Corp.AdventureWorks.Entities.Concrete;

namespace Corp.AdventureWorks.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductCategoryMap : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMap()
        {
            ToTable(@"ProductCategory", @"SalesLT");
            HasKey(x => x.ProductCategoryId);

            Property(x => x.ProductCategoryId).HasColumnName(@"ProductCategoryId");
            Property(x => x.ParentProductCategoryId).HasColumnName(@"ParentProductCategoryId");
            Property(x => x.Name).HasColumnName(@"Name");
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate");
        }
    }
}