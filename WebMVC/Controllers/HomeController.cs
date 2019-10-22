using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMVC.Models;
using WebMVC.Services;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReceitaService _receitaSvc;

        public HomeController(IReceitaService receitaSvc) => _receitaSvc = receitaSvc;

        public IActionResult Index()
        {
            return View();
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

        public JsonResult LatestCookie()
        {
            var cookies = _receitaSvc.GetLatestCookies();
            return Json(cookies);
        }
    }
}
