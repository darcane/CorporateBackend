using System.Reflection;
using Corp.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Corp.AdventureWorks.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently
                .Configure()
                .Database(
                    MsSqlConfiguration.MsSql2012
                        .ConnectionString(c=>c.FromConnectionStringWithKey("AdventureWorksContext")))
                .Mappings(t=> t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }
    }
}