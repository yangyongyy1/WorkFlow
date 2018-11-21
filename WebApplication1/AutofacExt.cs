using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public static class AutofacExt
    {

        private static IContainer _container;
        public static IContainer InitAutofac(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            //注册Domain和Repository
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "//Domain.dll")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "//Repositore.dll")).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("Domain")).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("Repositore")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.Populate(services);
            _container = builder.Build();
            return _container;
        }

        /// <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static T GetFromFac<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
