using Business.Constans;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperations : MethodInterception
    {
        //JWT için yetki kontrolü
        public class SecuredOperation : MethodInterception
        {
            private string[] _roles;
            private IHttpContextAccessor _httpContextAccessor;

            public SecuredOperation(string roles)
            {
                _roles = roles.Split(',');//bir metni benim belirttiğim karaktere göre ayırıp bir array e aktarır
                _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

            }
            //method un önünde çalıştır demek
            protected override void OnBefore(IInvocation invocation)
            {
                var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
                foreach (var role in _roles)
                {
                    if (roleClaims.Contains(role))
                    {
                        return;
                    }
                }
                throw new Exception(Messages.AuthorizationDenied);
            }
        }
    }
}
