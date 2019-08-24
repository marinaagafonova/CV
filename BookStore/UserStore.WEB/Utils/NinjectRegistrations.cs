using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserStore.BLL.Services;
using UserStore.BLL.Interfaces;
using Ninject.Modules;
using System.Web.ModelBinding;

namespace UserStore.Utils
{
	public class NinjectRegistrations : NinjectModule
	{
		private ServiceCreator ServiceCreator { get; set; } = new ServiceCreator("DefaultConnection");

		public NinjectRegistrations()
		{

		}

		public override void Load()
		{
			Bind<IServiceCreator>().ToConstant<ServiceCreator>(ServiceCreator);
			Bind<IDiscountCardService>().ToMethod<IDiscountCardService>(context => ServiceCreator.CreateDiscountCardService());
			Bind<IUserService>().ToMethod<IUserService>(context => ServiceCreator.CreateUserService());
			Bind<IProductService>().ToMethod<IProductService>(context => ServiceCreator.CreateProductService());
			Bind<IOrderService>().ToMethod<IOrderService>(context => ServiceCreator.CreateOrderService());
			Bind<ICustomerService>().ToMethod<ICustomerService>(context => ServiceCreator.CreateCustomerService());
		}
	}

}