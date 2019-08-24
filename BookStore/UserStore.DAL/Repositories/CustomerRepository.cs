using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UserStore.DAL.Entities;
using UserStore.DAL.EF;
using UserStore.DAL.Interfaces;

namespace UserStore.DAL.Repositories
{
	public class CustomerRepository : IRepository<Customer>
	{
		private ApplicationContext db;

		public CustomerRepository(ApplicationContext context)
		{
			this.db = context;
		}

		public IEnumerable<Customer> GetAll()
		{
			var list = db.Customers.ToList();

			return list ?? new List<Customer>();
		}

		public Customer Get(int id)
		{
			return db.Customers.Find(id);
		}

		public void Create(Customer customer)
		{
			db.Customers.Add(customer);
		}

		public void Update(Customer customer)
		{
			db.Entry(customer).State = EntityState.Modified;
		}

		public IEnumerable<Customer> Find(Func<Customer, Boolean> predicate)
		{
			return db.Customers.Where(predicate).ToList();
		}

		public void Delete(int id)
		{
			Customer customer = db.Customers.Find(id);

			if (customer != null)
				db.Customers.Remove(customer);
		}
	}
}