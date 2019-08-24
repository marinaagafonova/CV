using System;
using UserStore.BLL.DTO;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;
using UserStore.BLL.Infrastructure;
using UserStore.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;

namespace UserStore.BLL.Services
{
	public class OrderService : IOrderService
	{
		IUnitOfWork Database { get; set; }

		public OrderService(IUnitOfWork uow)
		{
			Database = uow;
		}

		public void Add(OrderDTO dto)
		{
			Order item = new Order
			{
				Customer = Database.CustomerRepository.Get(dto.CustomerId),
				CustomerId = dto.CustomerId,
				Date = dto.Date,
				Price = dto.Price,
				Products = dto.Products.Select((v) => Database.ProductRepository.Get(v.Id)).ToList(),
			};

			Database.OrderRepository.Create(item);
			Database.Save();
		}

		public IEnumerable<OrderDTO> GetAll()
		{
			var itemsList = Database.OrderRepository.GetAll();
			var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDTO>()).CreateMapper();
			return mapper.Map<IEnumerable<Order>, List<OrderDTO>>(itemsList);
		}

		public OrderDTO Get(int? id)
		{
			if (id == null)
				throw new ValidationException("ID не указан", "");

			var item = Database.OrderRepository.Get(id.Value);

			if (item == null)
				throw new ValidationException("Элемент не найден", "");

			var productsMapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
			var productsDTOs = productsMapper.Map<IEnumerable<Product>, List<ProductDTO>>(item.Products);

			return new OrderDTO
			{
				Id = item.Id,
				CustomerId = item.CustomerId,
				CustomerName = item.Customer.Name,
				Date = item.Date,
				Price = item.Price,
				Products = productsDTOs
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

			Database.OrderRepository.Delete(id.Value);
			Database.Save();
		}

		public void Update(OrderDTO dto)
		{
			Order item = Database.OrderRepository.Get(dto.Id);

			if (item == null)
				throw new ValidationException("Записи не существует", "");

			item.Price = dto.Price;
			item.Date = dto.Date;
			item.Products = dto.Products.Select((v) => Database.ProductRepository.Get(v.Id)).ToList();

			Database.OrderRepository.Update(item);
			Database.Save();
		}
	}
}