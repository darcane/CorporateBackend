using Corp.Core.DataAccess;
using Corp.Northwind.Entities.Concrete;

namespace Corp.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}