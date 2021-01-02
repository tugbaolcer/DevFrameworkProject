using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.Entities.Concrete
{
    public class Product : IEntity
    {
        //Primary key en üste sonra foregin keyler yazılır.
        public virtual int ProductID { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }

    }
}