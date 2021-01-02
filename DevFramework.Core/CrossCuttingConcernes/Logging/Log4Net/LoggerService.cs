using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Core.CrossCuttingConcernes.Logging.Log4Net
{
    [Serializable]
    public class LoggerService
    {
        private ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }

        //Bilgi logları açık mı diye konrol edecek.
        public bool IsInfoEnabled => _log.IsInfoEnabled;
        //Loglama ortamındaki debug kontolu açık mı diye kontol sağlanacak
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        //Loglamadan uyarı kontolü
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        //Fatal için kontol sağlama
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        //Loglamada hata var mı kontorülü
        public bool IsErrorEnabled => _log.IsErrorEnabled;

        public void Info(object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Info(logMessage);
            }
        }

        public void Debug(object logMessage)
        {
            if (IsDebugEnabled)
            {
                _log.Debug(logMessage);
            }
        }

        public void Warn(object logMessage)
        {
            if (IsWarnEnabled)
            {
                _log.Warn(logMessage);
            }
        }

        public void Fatal(object logMessage)
        {
            if (IsFatalEnabled)
            {
                _log.Fatal(logMessage);
            }
        }

        public void Error(object logMessage)
        {
            if (IsErrorEnabled)
            {
                _log.Error(logMessage);
            }
        }
    }
}
