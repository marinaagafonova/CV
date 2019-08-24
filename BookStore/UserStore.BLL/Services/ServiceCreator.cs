using UserStore.BLL.Interfaces;
using UserStore.DAL.Repositories;

namespace UserStore.BLL.Services
{
    public class ServiceCreator : IServiceCreator
    {
		private IdentityUnitOfWork database;

		public ServiceCreator(string connection)
		{
			database = new IdentityUnitOfWork(connection);
		}

        public IUserService CreateUserService()
        {
            return new UserService(database);
        }

		public IDiscountCardService CreateDiscountCardService()
		{
			return new DiscountCardService(database);
		}

		public IProductService CreateProductService()
		{
			return new ProductService(database);
		}

		public IOrderService CreateOrderService()
		{
			return new OrderService(database);
		}

		public ICustomerService CreateCustomerService()
		{
			return new CustomerService(database);
		}
    }
}
