using System;
using UserStore.BLL.DTO;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;
using UserStore.BLL.Infrastructure;
using UserStore.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace UserStore.BLL.Services
{
	public class ProductService : IProductService
	{
		IUnitOfWork Database { get; set; }

		public ProductService(IUnitOfWork uow)
		{
			Database = uow;
		}

		public void Add(ProductDTO dto)
		{
			Product item = new Product
			{
				Name = dto.Name,
				Price = dto.Price
			};

			Database.ProductRepository.Create(item);
			Database.Save();
		}

		public IEnumerable<ProductDTO> GetAll()
		{
			var itemsList = Database.ProductRepository.GetAll();
			var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
			return mapper.Map<IEnumerable<Product>, List<ProductDTO>>(itemsList);
		}

		public ProductDTO Get(int? id)
		{
			if (id == null)
				throw new ValidationException("ID не указан", "");

			var item = Database.ProductRepository.Get(id.Value);

			if (item == null)
				throw new ValidationException("Элемент не найден", "");

			return new ProductDTO
			{
				Id = item.Id,
				Name = item.Name,
				Price = item.Price
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

			Database.ProductRepository.Delete(id.Value);
			Database.Save();
		}

		public void Update(ProductDTO dto)
		{
			Product item = Database.ProductRepository.Get(dto.Id);

			if (item == null)
				throw new ValidationException("Записи не существует", "");

			item.Name = dto.Name;
			item.Price = dto.Price;

			Database.ProductRepository.Update(item);
			Database.Save();
		}
	}
}