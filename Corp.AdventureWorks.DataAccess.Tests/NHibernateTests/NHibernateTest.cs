using Corp.AdventureWorks.DataAccess.Concrete.NHibernate;
using Corp.AdventureWorks.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Corp.AdventureWorks.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_more_than_zero_elements()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreNotEqual(0,result.Count);
        }
    }
}
