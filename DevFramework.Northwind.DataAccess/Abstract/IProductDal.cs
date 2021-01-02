using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.DataAccess.Abstract
{
    //Ürüne özgü methotları burada ekleyebiliriz.
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}