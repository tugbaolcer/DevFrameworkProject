using log4net.Core;
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
    public class SerializableLogEvent
    {
        private LoggingEvent _loggingEvent;

        public SerializableLogEvent(LoggingEvent loggingEvent)
        {
            _loggingEvent = loggingEvent;
        }

        public string UserName => _loggingEvent.UserName;
        public object MessageObject => _loggingEvent.MessageObject;
    }
}
