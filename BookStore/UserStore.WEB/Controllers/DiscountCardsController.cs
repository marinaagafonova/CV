using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserStore.BLL.Interfaces;
using UserStore.BLL.DTO;
using UserStore.Models;
using UserStore.Models.DiscountCard;
using AutoMapper;
using UserStore.BLL.Infrastructure;

namespace NLayerApp.WEB.Controllers
{
	public class DiscountCardsController : Controller
	{
		private IDiscountCardService DiscountCardService;

		public DiscountCardsController(IDiscountCardService service)
		{
			DiscountCardService = service;
		}

		public ActionResult Index()
		{
			IEnumerable<DiscountCardDTO> itemsDto = DiscountCardService.GetCards();
			var mapper = new MapperConfiguration(cfg => cfg.CreateMap<DiscountCardDTO, DiscountCardViewModel>()).CreateMapper();
			var items = mapper.Map<IEnumerable<DiscountCardDTO>, List<DiscountCardViewModel>>(itemsDto);
			return View(items);
		}


		// GET: Products/Edit/5
		public ActionResult Edit(int? id)
		{
			try
			{
				var itemDto = DiscountCardService.GetCard(id);
				var item = new DiscountCardEditModel
				{
					Code = itemDto.Code,
					//DiscountPercent = itemDto.DiscountPercent
				};

				return View(item);
			}
			catch (ValidationException ex)
			{
				return Content(ex.Message);
			}
		}

		[HttpPost]
		public ActionResult Edit(int id, DiscountCardEditModel itemRaw)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var itemDto = new DiscountCardDTO
					{
						Id = id,
						//DiscountPercent = itemRaw.DiscountPercent,
						Code = itemRaw.Code,
					};

					DiscountCardService.UpdateCard(itemDto);

					return RedirectToAction("Index");
				}
				catch (ValidationException ex)
				{
					ModelState.AddModelError(ex.Property, ex.Message);
				}
			}

			return View(itemRaw);
		}

	}
}