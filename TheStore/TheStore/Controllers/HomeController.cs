using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheStore.Models;

namespace TheStore.Controllers
{
    public class HomeController : Controller
    {
        private IRobotoRepo _repo;

        public HomeController(IRobotoRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This action is only for bestest Doges
        /// </summary>
        /// <returns></returns>
        [Authorize(Policy = "IsDoge")]
        public IActionResult Doge()
        {
            return View();
        }
    }
}