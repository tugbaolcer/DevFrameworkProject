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
    public class CacheRemoveAspect : OnMethodBoundaryAspect
    {
        private string _pattern;
        private Type _cacheType;
        private ICachaManager _cacheManager;

        public CacheRemoveAspect(Type cacheType)
        {
            _cacheType = cacheType;
        }

        public CacheRemoveAspect(string pattern, Type cacheType)
        {
            _pattern = pattern;
            _cacheType = cacheType;
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

        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.RemoveByPattern(string.IsNullOrEmpty(_pattern)
                ? string.Format("{0}.{1}.*", args.Method.ReflectedType.Namespace, args.Method.ReflectedType.Name)
                : _pattern);
        }
    }
}