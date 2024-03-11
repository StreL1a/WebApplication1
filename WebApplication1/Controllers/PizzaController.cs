
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;  
using System.Collections.Generic;
public class PizzaController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(User user)
    {
        if (user.Age > 16)
        {
            ViewBag.ProductsCount = user.Age;
            return View("OrderProducts");
        }
        else
        {
            return View("TooYoung");
        }
    }

    [HttpPost]
    public IActionResult OrderProducts(List<Product> products)
    {
        // Обробка замовлення
        return View("OrderConfirmation", products);
    }
}