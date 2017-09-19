using ITChallengeCompat.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using System.Web.Http.Dispatcher;

namespace ITChallengeCompat.App_Start
{
    public class MyDependencyResolver : IDependencyResolver
    {
        private AppUserRepository _users;
        private MyControllerActivator _controllers;

        public MyDependencyResolver()
        {
            _users = new AppUserRepository();
            _controllers = new MyControllerActivator(this);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose()
        {
            // do nothing
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(AppUserRepository))
                return _users;
            else if (serviceType == typeof(IHttpControllerActivator))
                return _controllers;
            else
                return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            object service = GetService(serviceType);
            if (service != null)
                yield return service;
        }
    }
}