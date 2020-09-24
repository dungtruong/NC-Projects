using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NaturalCosmetics.Interface;
using NaturalCosmetics.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaturalCosmetics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICosmeticsRepository _cosmeticsRepository;
        public HomeController(ICosmeticsRepository cosmeticsRepository)
        {
            _cosmeticsRepository = cosmeticsRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(new HomeViewModel
            {
                HotItem=await _cosmeticsRepository.GetHotItem()
            });
        }
    }
}
