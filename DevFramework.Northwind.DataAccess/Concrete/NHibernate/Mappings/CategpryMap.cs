using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {

            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryID).Column("CategoryID");
            Map(x => x.CategoryName).Column("CategoryName");


        }
    }
}