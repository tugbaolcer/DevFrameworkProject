using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Core.Utilities.Common
{
    //Clientin kullanacağı nesneler burada üretilir.
    //http://localhost:55976/ProductService.svc
    public class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            string baseAddress = ConfigurationManager.AppSettings["ServiceAddress"];
            string address = string.Format(baseAddress, typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding, address);

            return channel.CreateChannel();
        }
    }
}