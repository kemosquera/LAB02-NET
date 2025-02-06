using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
     public IActionResult About()
        {
            return View(); // Looks for Views/Home/About.cshtml
        }

        public IActionResult Contact()
        {
            return View(); // Looks for Views/Home/Contact.cshtml
        }
}







