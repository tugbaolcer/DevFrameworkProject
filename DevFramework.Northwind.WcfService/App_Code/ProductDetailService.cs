using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;
using DevFramework.Northwind.Business.ServiceContracts.Wcf;
using DevFramework.Northwind.Entities.Concrete;

// NOT: "IProductService" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
[ServiceContract]
public class ProductDetailService:IProductDetailService
{
    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }

    //[OperationContract]
    //void DoWork();

}
