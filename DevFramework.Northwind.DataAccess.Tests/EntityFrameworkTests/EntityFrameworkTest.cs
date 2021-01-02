using System;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFameworkTest
    {
        [TestMethod]
        public void Get_all_return_all_products()
        {
            EfProductDal efProductDal = new EfProductDal();

            var result = efProductDal.GetList();//77

            Assert.AreEqual(77, result.Count);

        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filter_prducts()
        {
            EfProductDal efProductDal = new EfProductDal();

            var result = efProductDal.GetList(p => p.ProductName.Contains("ab"));//içinde ab geçen ürünleri listele

            Assert.AreEqual(4, result.Count);

        }
    }
}
