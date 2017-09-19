using ITChallengeCompat.Controllers;
using ITChallengeCompat.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dependencies;
using System.Web.Http.Dispatcher;

namespace ITChallengeCompat.App_Start
{
    public class MyControllerActivator : IHttpControllerActivator
    {
        private IDependencyResolver _resolver;

        public MyControllerActivator(IDependencyResolver resolver)
        {
            _resolver = resolver;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            if (controllerType == typeof(UsersController))
                return new UsersController((AppUserRepository)_resolver.GetService(typeof(AppUserRepository)));
            else
                return (IHttpController)controllerType.GetConstructor(new Type[0]).Invoke(null);
        }
    }
}