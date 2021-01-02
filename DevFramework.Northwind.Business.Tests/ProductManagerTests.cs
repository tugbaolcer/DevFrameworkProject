using System;
using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            //Mock<IProductDal> mock = new Mock<IProductDal>();
            //ProductManager manager = new ProductManager(mock.Object);
            //manager.Add(new Product());

        }
    }
}