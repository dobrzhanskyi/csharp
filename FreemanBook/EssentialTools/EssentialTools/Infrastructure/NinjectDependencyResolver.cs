using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Ninject.Syntax;
using Ninject.Parameters;
using EssentialTools.Models;

namespace EssentialTools.Infrastructure
{
	public class NinjectDependencyResolver : IDependencyResolver
	{
		private IKernel _kernel;

		public NinjectDependencyResolver()
		{
			_kernel = new StandardKernel();
			AddBindings();
		}

		private void AddBindings()
		{
			_kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
			_kernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>().WithConstructorArgument("discountParam", 150M);
			_kernel.Bind<IDiscountHelper>().To<FlexibleDiscountHelper>().WhenInjectedInto<LinqValueCalculator>();
				}

		public object GetService(Type serviceType)
		{
			return _kernel.TryGet(serviceType);
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			return _kernel.GetAll(serviceType);
		}
	}
}