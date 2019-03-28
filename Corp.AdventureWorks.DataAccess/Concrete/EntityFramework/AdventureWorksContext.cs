using System.Data.Entity;
using Corp.AdventureWorks.DataAccess.Concrete.EntityFramework.Mappings;
using Corp.AdventureWorks.Entities.Concrete;

namespace Corp.AdventureWorks.DataAccess.Concrete.EntityFramework
{
    public class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext()
        {
            Database.SetInitializer<AdventureWorksContext>(null); // block code from generating tables on db
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
        }
    }
}