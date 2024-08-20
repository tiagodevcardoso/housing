using Housing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Housing.Controllers.Front
{
    public class AdministratorController : Controller
    {
        private readonly ILogger<AdministratorController> _logger;

        public AdministratorController(ILogger<AdministratorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
