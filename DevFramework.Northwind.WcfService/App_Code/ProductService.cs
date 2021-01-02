using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;
using DevFramework.Northwind.Entities.Concrete;

// NOT: "ProductService" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
public class ProductService : IProductService
{
    public ProductService()
    {
            
    }
    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }

    public Product GetById(int id)
    {
        return _productService.GetById(id);
    }

    public Product Add(Product product)
    {
        return _productService.Add(product);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }

    public void TransactionalOperation(Product product1, Product product2)
    {
        _productService.TransactionalOperation(product1, product2);
    }

    //public void DoWork()
    //{
    //}
}
