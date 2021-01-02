using DevFramework.Core.CrossCuttingConcernes.Logging;
using DevFramework.Core.CrossCuttingConcernes.Logging.Log4Net;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Core.Aspects.Postsharp.LogAspects
{
    [Serializable]
    //Nesne örneklerinin methodlarına uygula anlamındır.Constracturelara uygulama yani
    [MulticastAttributeUsage(MulticastTargets.Method, TargetMemberAttributes = MulticastAttributes.Instance)]
    public class LogAspect : OnMethodBoundaryAspect
    {
        private Type _loggerType;
        private LoggerService _loggerService;

        public LogAspect(Type loggerType)
        {
            _loggerType = loggerType;
        }

        //intance üretmek için buradan yaralanılır.
        public override void RuntimeInitialize(MethodBase method)
        {
            if (_loggerType.BaseType != typeof(LoggerService))
            {
                throw new Exception("Wrong logger type");
            }
            _loggerService = (LoggerService)Activator.CreateInstance(_loggerType);
            base.RuntimeInitialize(method);
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            if (!_loggerService.IsInfoEnabled)
            {
                return;
            }
            try
            {

                var logParameters = args.Method.GetParameters().Select((t, i) => new LogParameter
                {
                    Name = t.Name,
                    Type = t.ParameterType.Name,
                    Value = args.Arguments.GetArgument(i)
                }).ToList();

                var logDetail = new LogDetail
                {
                    FullName = args.Method.DeclaringType == null ? null : args.Method.DeclaringType.Name,
                    MethodName = args.Method.Name,
                    Parameters = logParameters
                };

                _loggerService.Info(logDetail);
            }
            catch
            {

            }
        }
    }
}
