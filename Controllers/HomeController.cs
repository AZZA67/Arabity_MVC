using Arabitey.Models;
using Arabitey.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Arabitey.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ICarBrandRepository icarbrandrepository;

        public HomeController(ILogger<HomeController> logger, ICarBrandRepository _icarbrandrepository)
        {
            _logger = logger;
            icarbrandrepository = _icarbrandrepository;
        }

        public IActionResult Index()
        {
            List<CarBrand> Brandlist = icarbrandrepository.GetAll();
            return View("GetAllwithCars", Brandlist);
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
