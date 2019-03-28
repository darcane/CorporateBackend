using Corp.AdventureWorks.DataAccess.Abstract;
using Corp.AdventureWorks.Entities.Concrete;
using Corp.Core.DataAccess.EntityFramework;

namespace Corp.AdventureWorks.DataAccess.Concrete.EntityFramework
{
    public class EfProductCategoryDal : EfEntityRepositoryBase<ProductCategory, AdventureWorksContext>, IProductCategoryDal
    {
        
    }
}