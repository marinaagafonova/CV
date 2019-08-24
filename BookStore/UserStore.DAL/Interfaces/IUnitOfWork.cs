using UserStore.DAL.Identity;
using System;
using System.Threading.Tasks;
using UserStore.DAL.Entities;

namespace UserStore.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ApplicationRoleManager RoleManager { get; }

		IRepository<Customer> CustomerRepository { get; }
		IRepository<Order> OrderRepository { get; }
		IRepository<Product> ProductRepository { get; }
		IRepository<DiscountCard> DiscountCardRepository { get; }

		void Save();
        Task SaveAsync();
    }
}
