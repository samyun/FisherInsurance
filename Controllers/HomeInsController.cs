using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;

public class HomeInsController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the HomeInsController");
        return View();
    }
    public IActionResult Quote()
    {
        Quote quote = new Quote
        {
            Id = 345,
            Product = "Home Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };
        //return Ok("This is the quote of the HomeInsController");
    
        return View(quote);
    }
}