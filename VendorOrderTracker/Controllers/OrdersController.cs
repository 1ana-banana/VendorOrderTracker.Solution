using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> orderList = Order.GetList();
      return View(orderList);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      List<Vendor> vendorList = Order.VendorGetList();
      return View(vendorList);
    }

    [HttpPost("/orders")]
    public ActionResult Create(int orderVendorId, string title, string description, int price, string orderDate, string deliveryForDate, int sourDough, int milkLoaf, int donut, int croissant, int quiche, int cheesePuff)
    {
      Order order = new Order(orderVendorId, title, description, price, orderDate, deliveryForDate, sourDough, milkLoaf, donut, croissant, quiche, cheesePuff);
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order selectedOrder = Order.FindById(id);
      return View(selectedOrder);
    }
  }
}