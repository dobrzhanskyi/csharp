using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using Ninject;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Infrastructure
{
	public class NinjectControllerFactory : DefaultControllerFactory
	{
		private IKernel ninjectKernel;

		public NinjectControllerFactory()
		{
			ninjectKernel = new StandardKernel();
			AddBindings();
		}

		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			return controllerType == null
				? null
				: (IController)ninjectKernel.Get(controllerType);
		}

		private void AddBindings()
		{
			Mock<IProductRepository> mock = new Mock<IProductRepository>();
			mock.Setup(m => m.Products).Returns(new List<Product>
				{
				new Product{Name="Football",Price=25},
				new Product{Name="Surf board",Price=179},
				new Product{Name="Running shoes",Price=95}
				}.AsQueryable());
			ninjectKernel.Bind<IProductRepository>().ToConstant(mock.Object);
		}
	}
}