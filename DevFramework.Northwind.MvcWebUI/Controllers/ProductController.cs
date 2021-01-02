﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Northwind.MvcWebUI.Models;

/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Product
            {
                CategoryID = 1,
                ProductName = "Gsm",
                QuantityPerUnit = "1",
                UnitPrice = 21
            });
            return "Added";
        }

        public string AddUpdate()
        {
            _productService.TransactionalOperation(new Product
                {
                    CategoryID = 1,
                    ProductName = "Computer",
                    QuantityPerUnit = "1",
                    UnitPrice = 21
                },
                new Product
                {
                    CategoryID = 1,
                    ProductName = "Computer 2",
                    QuantityPerUnit = "1",
                    UnitPrice = 10,
                    ProductID = 2
                }
            );

            return "Done";
        }
    }
}