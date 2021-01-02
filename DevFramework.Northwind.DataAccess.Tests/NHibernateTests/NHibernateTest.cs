using System;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NhibernateTest
    {
        [TestMethod]
        public void Get_all_return_all_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList();//77

            Assert.AreEqual(77, result.Count);

        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filter_prducts()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList(p => p.ProductName.Contains("ab"));//içinde ab geçen ürünleri listele

            Assert.AreEqual(4, result.Count);

        }
    }
}
