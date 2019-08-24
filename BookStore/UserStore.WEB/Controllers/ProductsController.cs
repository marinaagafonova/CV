using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserStore.BLL.Interfaces;
using UserStore.BLL.DTO;
using UserStore.Models;
using UserStore.Models.Product;
using AutoMapper;
using UserStore.BLL.Infrastructure;

namespace UserStore.Controllers
{
    public class ProductsController : Controller
    {
		private IProductService DiscountCardService;

		public ProductsController(IProductService service)
		{
			DiscountCardService = service;
		}


		// GET: Products
		public ActionResult Index()
        {
			var itemsDto = DiscountCardService.GetAll();
			var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductViewModel>()).CreateMapper();
			var items = mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(itemsDto);

			return View(items);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
			var item = new ProductEditModel {
				Name = "",
				Price = 0,
			};

            return View(item);
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(ProductEditModel itemRaw)
        {
			if (ModelState.IsValid)
			{
				try
				{
					var itemDto = new ProductDTO
					{
						Name = itemRaw.Name,
						Price = itemRaw.Price,
					};

					DiscountCardService.Add(itemDto);

					return RedirectToAction("Index");
				}
				catch (ValidationException ex)
				{
					ModelState.AddModelError(ex.Property, ex.Message);
				}
			}

			return View(itemRaw);
		}

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
			try
			{
				var itemDto = DiscountCardService.Get(id);
				var item = new ProductEditModel
				{
					Name = itemDto.Name,
					Price = itemDto.Price
				};

				return View(item);
			}
			catch (ValidationException ex)
			{
				return Content(ex.Message);
			}
		}

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductEditModel itemRaw)
        {
			if (ModelState.IsValid)
			{
				try
				{
					var itemDto = new ProductDTO
					{
						Id = id,
						Name = itemRaw.Name,
						Price = itemRaw.Price,
					};

					DiscountCardService.Update(itemDto);

					return RedirectToAction("Index");
				}
				catch (ValidationException ex)
				{
					ModelState.AddModelError(ex.Property, ex.Message);
				}
			}

			return View(itemRaw);
		}

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
			try
			{
				DiscountCardService.Delete(id);
			}
			catch (ValidationException ex)
			{
			}

			return RedirectToAction("Index");
		}
    }
}
