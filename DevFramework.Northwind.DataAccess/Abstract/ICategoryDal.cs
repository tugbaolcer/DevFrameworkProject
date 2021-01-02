
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;

/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}