using InternApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InternApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<AppCards> cards = new List<AppCards>();
            AppCards card = new AppCards();
            card.Title = "BMI Calculator";
            card.Text ="You can calculate your body mass index here!";
            card.Img = "https://wellversed.in/cdn/shop/articles/shutterstock_584016211_1_1170x.jpg?v=1596612878";

            cards.Add(card);
            
            return View(cards);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}