using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserStore.BLL.Interfaces;
using UserStore.BLL.DTO;
using UserStore.Models;
using UserStore.Models.Customer;
using AutoMapper;
using UserStore.BLL.Infrastructure;
using UserStore.Models.Product;

namespace UserStore.Controllers
{
    public class CustomersController : Controller
    {
		private ICustomerService CustomerService;
		private IOrderService OrderService;

		public CustomersController(ICustomerService customerService, IOrderService orderService)
		{
			CustomerService = customerService;
			OrderService = orderService;
		}

		// GET: Customers
		public ActionResult Index()
        {
			var rawItems = CustomerService.GetAll();
			var items = rawItems.Select((v) => new CustomerViewModel()
			{
				Address = v.Address,
				DiscountCardCode = v.DiscountCardCode,
				DiscountCardId = v.DiscountCardId,
				Id = v.Id,
				Name = v.Name,
				OrdersNames = v.Orders.Select((k) => k.Id.ToString() + " " + k.Date.ToString()).ToList()
			});

			return View(items);
		}

		// GET: Products/Create
		public ActionResult Create()
		{
			var item = new CustomerEditModel
			{
				Name = "",
				Address = "",
			};

			return View(item);
		}

		// POST: Products/Create
		[HttpPost]
		public ActionResult Create(CustomerEditModel itemRaw)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var itemDto = new CustomerDTO
					{
						Name = itemRaw.Name,
						Address = itemRaw.Address,
					};

					CustomerService.Add(itemDto);

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
				var itemDto = CustomerService.Get(id);
				var item = new CustomerEditModel
				{
					Name = itemDto.Name,
					Address = itemDto.Address
				};

				return View(item);
			}
			catch (ValidationException ex)
			{
				return Content(ex.Message);
			}
		}

		[HttpPost]
		public ActionResult Edit(int id, CustomerEditModel itemRaw)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var itemDto = new CustomerDTO
					{
						Id = id,
						Name = itemRaw.Name,
						Address = itemRaw.Address,
					};

					CustomerService.Update(itemDto);

					return RedirectToAction("Index");
				}
				catch (ValidationException ex)
				{
					ModelState.AddModelError(ex.Property, ex.Message);
				}
			}

			return View(itemRaw);
		}

		public ActionResult Delete(int? id)
		{
			try
			{
				CustomerService.Delete(id);
			}
			catch (ValidationException ex)
			{
			}

			return RedirectToAction("Index");
		}
	}
}
