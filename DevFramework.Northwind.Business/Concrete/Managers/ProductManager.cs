using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Threading;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using DevFramework.Northwind.Entities.Concrete;

using AutoMapper;
using DevFramework.Core.Aspects.Postsharp.AuthorizationAspects;
using DevFramework.Core.Aspects.Postsharp.CacheAspects;
using DevFramework.Core.Aspects.Postsharp.LogAspects;
using DevFramework.Core.Aspects.Postsharp.PerformanceAspects;
using DevFramework.Core.Aspects.Postsharp.TransactionAspects;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using DevFramework.Core.CrossCuttingConcernes.Caching.Microsoft;
using DevFramework.Northwind.DataAccess.Abstract;


/*
 Created by OlcerTugba 2020
 */

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    [LogAspect(typeof(DatabaseLogger))]
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(2)]
        [SecuredOperation(Roles="Admin,Editor,Student")]
        public List<Product> GetAll()
        {

            //Automaper kullanılmadan önce manuel şekilde yazımı böyledir.

            //return _productDal.GetList().Select(p => new Product
            //{
            //    CategoryID = p.CategoryID,
            //    ProductID = p.ProductID,
            //    ProductName = p.ProductName,
            //    QuantityPerUnit = p.QuantityPerUnit,
            //    UnitPrice = p.UnitPrice

            //}).ToList();

            //Automaper kullnımı
            var products = _mapper.Map<List<Product>>(_productDal.GetList());
            return products;


        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductID == id);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(ProductValidator))]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            _productDal.Add(product2);
        }
    }
}