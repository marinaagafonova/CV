using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UserStore.DAL.Entities;
using UserStore.DAL.EF;
using UserStore.DAL.Interfaces;

namespace UserStore.DAL.Repositories
{
	public class DiscountCardRepository : IRepository<DiscountCard>
	{
		private ApplicationContext db;

		public DiscountCardRepository(ApplicationContext context)
		{
			this.db = context;
		}

		public IEnumerable<DiscountCard> GetAll()
		{
			return db.DiscountCards;
		}

		public DiscountCard Get(int id)
		{
			return db.DiscountCards.Find(id);
		}

		public void Create(DiscountCard discountCard)
		{
			db.DiscountCards.Add(discountCard);
		}

		public void Update(DiscountCard discountCard)
		{
			db.Entry(discountCard).State = EntityState.Modified;
		}

		public IEnumerable<DiscountCard> Find(Func<DiscountCard, Boolean> predicate)
		{
			return db.DiscountCards.Where(predicate).ToList();
		}

		public void Delete(int id)
		{
			DiscountCard discountCard = db.DiscountCards.Find(id);

			if (discountCard != null)
				db.DiscountCards.Remove(discountCard);
		}
	}
}