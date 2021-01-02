using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Core.Aspects.Postsharp.AuthorizationAspects
{
    [Serializable]
    public class SecuredOperation : OnMethodBoundaryAspect
    {
        public string Roles { get; set; }
        //Methoda girdiğimiz zaman OnEntry kullanılır.
        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorized = false;
            for (int i = 0; i < roles.Length; i++)
            {
                if (System.Threading.Thread.CurrentPrincipal.IsInRole(roles[i]))//Eğer kullanıcı izin verilen rollaerden birine sahipse
                {
                    isAuthorized = true;
                }
            }

            if (!isAuthorized)
            {
                throw new SecurityException("You aren't authorized!");
            }

        }
    }
}