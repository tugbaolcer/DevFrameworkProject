using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Entities.Concrete;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.DataAccess.Concrete.Entityframework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.CategoryID);

            Property(x => x.CategoryID).HasColumnName("CategoryId");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
        }
    }
}