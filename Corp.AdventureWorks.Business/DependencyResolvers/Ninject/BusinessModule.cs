using System.Data.Entity;
using Corp.AdventureWorks.Business.Abstract;
using Corp.AdventureWorks.Business.Concrete.Managers;
using Corp.AdventureWorks.DataAccess.Abstract;
using Corp.AdventureWorks.DataAccess.Concrete.EntityFramework;
using Corp.AdventureWorks.DataAccess.Concrete.NHibernate;
using Corp.AdventureWorks.DataAccess.Concrete.NHibernate.Helpers;
using Corp.Core.DataAccess;
using Corp.Core.DataAccess.EntityFramework;
using Corp.Core.DataAccess.NHibernate;
using Ninject.Modules;

namespace Corp.AdventureWorks.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();

            //To use Entity Framework
            Bind<IProductDal>().To<EfProductDal>();
            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            //To use NHibernate
            //Bind<IProductDal>().To<NhProductDal>(); 
            //Bind(typeof(IQueryableRepository<>)).To(typeof(NhQueryableRepository<>));
            //Bind<NHibernateHelper>().To<SqlServerHelper>();

            Bind<DbContext>().To<AdventureWorksContext>();
        }
    }
}