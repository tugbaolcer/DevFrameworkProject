using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.CrossCuttingConcernes.Caching;
using PostSharp.Aspects;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheAspect : MethodInterceptionAspect
    {
        private Type _cacheType;
        private int _cacheByMinute;
        private ICachaManager _cacheManager;

        public CacheAspect(Type cacheType, int cacheByMinute = 60)
        {
            _cacheType = cacheType;
            _cacheByMinute = cacheByMinute;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICachaManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("Wrong Cache Manager");
            }
            _cacheManager = (ICachaManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var methodName = string.Format("{0}.{1}.{2}", args.Method.ReflectedType.Namespace,
                args.Method.ReflectedType.Name, args.Method.Name);
            var arguments = args.Arguments.ToList();
            var key = string.Format("{0}({1})", methodName,
                string.Join(",", arguments.Select(x => x != null ? x.ToString() : "<Null>")));

            if (_cacheManager.IsAdd(key))
            {
                args.ReturnValue = _cacheManager.Get<object>(key);
            }

            base.OnInvoke(args);
            _cacheManager.Add(key, args.ReturnValue, _cacheByMinute);
        }
    }
}