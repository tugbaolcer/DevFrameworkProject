using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Core.CrossCuttingConcernes.Logging
{
    public class LogDetail
    {
        public string FullName { get; set; }
        public string MethodName { get; set; }
        public List<LogParameter> Parameters { get; set; }
    }
}
