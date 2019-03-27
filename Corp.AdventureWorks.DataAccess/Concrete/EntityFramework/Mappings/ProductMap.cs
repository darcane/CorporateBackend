using System.Data.Entity.ModelConfiguration;
using Corp.AdventureWorks.Entities.Concrete;

namespace Corp.AdventureWorks.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Product", @"SalesLT");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName(@"ProductId");
            Property(x => x.Name).HasColumnName(@"Name");
            Property(x => x.ProductCategoryId).HasColumnName(@"ProductCategoryId");
            Property(x => x.ProductNumber).HasColumnName(@"ProductNumber");
            Property(x => x.ListPrice).HasColumnName(@"ListPrice");
        }
    }
}