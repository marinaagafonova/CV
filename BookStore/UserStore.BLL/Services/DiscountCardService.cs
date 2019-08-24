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
	public class DiscountCardService : IDiscountCardService
	{
		IUnitOfWork Database { get; set; }

		public DiscountCardService(IUnitOfWork uow)
		{
			Database = uow;
		}

		public void AddCard(DiscountCardDTO dto)
		{
			Customer customer = Database.CustomerRepository.Get(dto.CustomerId);

			if (customer == null)
				throw new ValidationException("Покупатель не найден", "");

			DiscountCard card = new DiscountCard
			{
				Id = dto.CustomerId,
				Code = dto.Code,
			};

			Database.DiscountCardRepository.Create(card);
			Database.Save();
		}

		public IEnumerable<DiscountCardDTO> GetCards()
		{
			var itemsList = Database.DiscountCardRepository.GetAll();
			var mapper = new MapperConfiguration(cfg => cfg.CreateMap<DiscountCard, DiscountCardDTO>()).CreateMapper();
			return mapper.Map<IEnumerable<DiscountCard>, List<DiscountCardDTO>>(itemsList);
		}

		public DiscountCardDTO GetCard(int? id)
		{
			if (id == null)
				throw new ValidationException("ID не указан", "");

			var card = Database.DiscountCardRepository.Get(id.Value);

			if (card == null)
				throw new ValidationException("Карта не найдена", "");

			return new DiscountCardDTO { Id = card.Id, CustomerId = card.Customer.Id, Code = card.Code,  CustomerName = card.Customer.Name };
		}

		public void Dispose()
		{
			Database.Dispose();
		}

		public void UpdateCard(DiscountCardDTO dto)
		{
			DiscountCard card = Database.DiscountCardRepository.Get(dto.Id);
			card.Code = dto.Code;

			Database.DiscountCardRepository.Update(card);
			Database.Save();
		}
	}
}