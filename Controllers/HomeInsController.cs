using Microsoft.AspNetCore.Mvc;

public class HomeInsController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the HomeInsController");
        return View("HomeIns");
    }
    public IActionResult Quote()
    {
        return Ok("This is the quote of the HomeInsController");
    }
}