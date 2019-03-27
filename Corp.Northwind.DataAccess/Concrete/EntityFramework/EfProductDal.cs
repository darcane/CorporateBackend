using Corp.Core.DataAccess.EntityFramework;
using Corp.Northwind.DataAccess.Abstract;
using Corp.Northwind.Entities.Concrete;

namespace Corp.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {

    }
}