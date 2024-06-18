using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using SupplierManager.Repository;
using SupplierManager.Service;

namespace SupplierManager.Web
{
	public class AutoFacConfig
	{
		public static void Register()
		{
			//构建一个autofac的builder容器
			var builder = new ContainerBuilder();
			//注册mvc中所有的controller
			builder.RegisterControllers(Assembly.GetCallingAssembly())
				.PropertiesAutowired();
			//	As<接口>.AsImplementedInterfaces()  
			builder.RegisterType<SupplierRepository>().As<ISupplierRepository>()
				.InstancePerRequest()
				.AsImplementedInterfaces()
				.PropertiesAutowired();
			builder.RegisterType<SupplierAppService>().InstancePerLifetimeScope();
			builder.RegisterType<SupplierDbContext>().InstancePerLifetimeScope();
			//创建一个AutoFac容器
			var container = builder.Build();
			//移除原本的mvc的容器，使用AutoFac的容器，将MVC的控制器对象实例交由autofac来创建
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}