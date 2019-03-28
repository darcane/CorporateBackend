using Corp.AdventureWorks.DataAccess.Abstract;
using Corp.AdventureWorks.Entities.Concrete;
using Corp.Core.DataAccess.NHibernate;

namespace Corp.AdventureWorks.DataAccess.Concrete.NHibernate
{
    public class NhProductCategoryDal : NhEntityRepositoryBase<ProductCategory>, IProductCategoryDal
    {
        public NhProductCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}