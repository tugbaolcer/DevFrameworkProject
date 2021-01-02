using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Core.Aspects.Postsharp.TransactionAspects
{
    [Serializable]
    public class TransactionScopeAspect : OnMethodBoundaryAspect
    {
        private TransactionScopeOption _option;

        public TransactionScopeAspect()
        {

        }

        public TransactionScopeAspect(TransactionScopeOption option)
        {
            _option = option;
        }
        //Methoda girildiğinde
        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope(_option);
        }
        //Method başarılıysa
        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }
        //Method başarısızsa
        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }
    }
}

