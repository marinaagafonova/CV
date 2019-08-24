using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserStore.BLL.Interfaces;
using UserStore.BLL.DTO;
using UserStore.Models;
using UserStore.Models.Order;
using AutoMapper;
using UserStore.BLL.Infrastructure;
using UserStore.Models.Product;

namespace UserStore.Controllers
{
	public class OrdersController : Controller
	{
		private IOrderService OrderService;
		private IProductService ProductService;
		private ICustomerService CustomerService;

		public OrdersController(IOrderService orderService, IProductService productService, ICustomerService customerService)
		{
			OrderService = orderService;
			ProductService = productService;
			CustomerService = customerService;
		}


		// GET: Products
		public ActionResult Index()
		{
			var itemsDto = OrderService.GetAll();
			var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderDTO, OrderViewModel>()).CreateMapper();
			var items = mapper.Map<IEnumerable<OrderDTO>, List<OrderViewModel>>(itemsDto);

			return View(items);
		}

		// GET: Products/Create
		public ActionResult Create()
		{
			var item = new OrderEditModel
			{
				Price = 0,
				Date = DateTime.Now,
				Products = new List<ProductViewModel>(),
				SelectedProducts = new List<int>(),
				ProductsSelectList = ProductService.GetAll().Select((v) => new SelectListItem() { Text = v.Name, Value = v.Id.ToString() }),
			};

			ViewBag.CustomersIds = new SelectList(CustomerService.GetAll(), "Id", "Name", null);

			return View(item);
		}

		// POST: Products/Create
		[HttpPost]
		public ActionResult Create(OrderEditModel itemRaw)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var itemDto = new OrderDTO
					{

						Date = itemRaw.Date,
						Price = itemRaw.Price,
						Products = itemRaw.SelectedProducts.Select((v) => ProductService.Get(v)).ToList(),
						CustomerId = itemRaw.CustomerId,
					};

					OrderService.Add(itemDto);

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
				var itemDto = OrderService.Get(id);
				var item = new OrderEditModel
				{
					CustomerId = itemDto.CustomerId,
					Date = itemDto.Date,
					Price = itemDto.Price,
					Products = itemDto.Products.Select((v) => new ProductViewModel() {
						Id = v.Id,
						Name = v.Name,
						Price = v.Price,
					}).ToList(),
					SelectedProducts = itemDto.Products.Select((v) => v.Id).ToList(),
					ProductsSelectList = ProductService.GetAll().Select((v) => new SelectListItem() { Text = v.Name, Value = v.Id.ToString() }),
				};

				var customers = CustomerService.GetAll();


				ViewBag.CustomersIds = new SelectList(customers, "Id", "Name",
					null);

				return View(item);
			}
			catch (ValidationException ex)
			{
				return Content(ex.Message);
			}
		}

		// POST: Products/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, OrderEditModel itemRaw)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var itemDto = new OrderDTO
					{
						Id = id,
						Date = itemRaw.Date,
						Price = itemRaw.Price,
						Products = itemRaw.SelectedProducts.Select((v) => ProductService.Get(v)).ToList(),
						CustomerId = itemRaw.CustomerId,
					};


					OrderService.Update(itemDto);

					return RedirectToAction("Index");
				}
				catch (ValidationException ex)
				{
					ModelState.AddModelError(ex.Property, ex.Message);
				}
			}
			else
			{
				var itemDto = OrderService.Get(id);
				itemRaw = new OrderEditModel
				{
					CustomerId = itemDto.CustomerId,
					Date = itemDto.Date,
					Price = itemDto.Price,
					Products = itemDto.Products.Select((v) => new ProductViewModel()
					{
						Id = v.Id,
						Name = v.Name,
						Price = v.Price,
					}).ToList(),
					SelectedProducts = itemDto.Products.Select((v) => v.Id).ToList(),
					ProductsSelectList = ProductService.GetAll().Select((v) => new SelectListItem() { Text = v.Name, Value = v.Id.ToString() }),
				};
			}

			return View(itemRaw);
		}

		// GET: Products/Delete/5
		public ActionResult Delete(int? id)
		{
			try
			{
				OrderService.Delete(id);
			}
			catch (ValidationException ex)
			{
			}

			return RedirectToAction("Index");
		}
	}
}
