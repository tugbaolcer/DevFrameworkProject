using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }


        //Gönderilen oracle, mssql fark etmeksizin veritabanı değereleri burada dönecek.
        protected abstract ISessionFactory InitializeFactory();

        //Veritabanından gönderilen değere göre session aç.
        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
