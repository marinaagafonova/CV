using UserStore.DAL.EF;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;
using UserStore.DAL.Identity;

namespace UserStore.DAL.Repositories
{
    public class IdentityUnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;

        private ApplicationUserManager userManager;
        private ApplicationRoleManager roleManager;
        private IClientManager clientManager;

		private IRepository<Customer> customerRepository;
		private IRepository<Order> orderRepository;
		private IRepository<Product> productRepository;
		private IRepository<DiscountCard> discountCardRepository;

		public IdentityUnitOfWork(string connectionString)
        {
            db = new ApplicationContext(connectionString);
            userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(db));
            clientManager = new ClientManager(db);

			customerRepository = new CustomerRepository(db);
			orderRepository = new OrderRepository(db);
			productRepository = new ProductRepository(db);
			discountCardRepository = new DiscountCardRepository(db);
		}

        public ApplicationUserManager UserManager
        {
            get { return userManager; }
        }

        public IClientManager ClientManager
        {
            get { return clientManager; }
        }

        public ApplicationRoleManager RoleManager
        {
            get { return roleManager; }
        }

		public IRepository<Customer> CustomerRepository
		{
			get { return customerRepository; }
		}

		public IRepository<Order> OrderRepository
		{
			get { return orderRepository; }
		}

		public IRepository<Product> ProductRepository
		{
			get { return productRepository; }
		}

		public IRepository<DiscountCard> DiscountCardRepository
		{
			get { return discountCardRepository; }
		}

		public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }

		public void Save()
		{
			try
			{
				db.SaveChanges();
			}
			catch (Exception e)
			{

			}
		}

		public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    userManager.Dispose();
                    roleManager.Dispose();
                    clientManager.Dispose();
				}
                this.disposed = true;
            }
        }
    }
}
