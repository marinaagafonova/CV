using System;
using System.Linq;
using UserStore.BLL.DTO;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;
using UserStore.BLL.Infrastructure;
using UserStore.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace UserStore.BLL.Services
{
	public class CustomerService : ICustomerService
	{
		IUnitOfWork Database { get; set; }

		public CustomerService(IUnitOfWork uow)
		{
			Database = uow;
		}

		public void Add(CustomerDTO dto)
		{
			Customer item = new Customer
			{
				Address = dto.Address,
				Name = dto.Name,
			};

			Database.CustomerRepository.Create(item);
			Database.Save();

			var discountCard = new DiscountCard()
			{
				Code = item.Id.ToString(),
				Id = item.Id,
				//DiscountPercent = 0
			};

			Database.DiscountCardRepository.Create(discountCard);

			Database.Save();
			item.DiscountCard = discountCard;

			Database.Save();
		}

		public IEnumerable<CustomerDTO> GetAll()
		{
			return Database.CustomerRepository.GetAll().Select((v) => new CustomerDTO() {
				Address = v.Address,
				DiscountCardCode = v.DiscountCard.Code,
				DiscountCardId = v.DiscountCard.Id,
				Id = v.Id,
				Name = v.Name,
				Orders = v.Orders.Select((k) => new OrderDTO() {
					Id = k.Id,
					Date = k.Date,
					Price = k.Price
				}).ToList(),
			});
		}

		public CustomerDTO Get(int? id)
		{
			if (id == null)
				throw new ValidationException("ID не указан", "");

			var item = Database.CustomerRepository.Get(id.Value);

			if (item == null)
				throw new ValidationException("Элемент не найден", "");
			
			var ordersMapper = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDTO>()).CreateMapper();
			var ordersDTOs = ordersMapper.Map<IEnumerable<Order>, List<OrderDTO>>(item.Orders);

			return new CustomerDTO
			{
				Id = item.Id,
				Name = item.Name,
				Address = item.Address,
				DiscountCardId = item.DiscountCard.Id,
				DiscountCardCode = item.DiscountCard.Code,
				Orders = ordersDTOs
			};
		}

		public void Dispose()
		{
			Database.Dispose();
		}

		public void Delete(int? id)
		{
			if (id == null)
				throw new ValidationException("ID не указан", "");


			var card = Database.CustomerRepository.Get(id.Value).DiscountCard;

			if (card != null)
				Database.DiscountCardRepository.Delete(card.Id);

			Database.CustomerRepository.Delete(id.Value);
			Database.Save();
		}

		public void Update(CustomerDTO dto)
		{
			Customer item = Database.CustomerRepository.Get(dto.Id);

			if (item == null)
				throw new ValidationException("Записи не существует", "");

			item.Name = dto.Name;
			//item.Price = dto.Price;

			Database.CustomerRepository.Update(item);
			Database.Save();
		}
	}
}