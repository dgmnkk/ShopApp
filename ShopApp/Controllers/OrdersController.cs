﻿using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ShopApp.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;
        private string UserId => User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }
        public IActionResult Index()
        {
            return View(ordersService.GetAllByUser(UserId));
        }

        public async Task<IActionResult> Create(int id)
        {
            await ordersService.Create(UserId, id);
            TempData["ToastMessage"] = "Order confirmed successfully!";

            return RedirectToAction(nameof(Index));
        }
    }
}
