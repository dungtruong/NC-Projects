using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NaturalCosmetics.Models;
using NaturalCosmetics.Core.Interface;
using NaturalCosmetics.Data;
using NaturalCosmetics.Interface;
using NaturalCosmetics.ViewModels;

namespace NaturalCosmetics.Controllers
{
    public class CosmeticsController : Controller
    {
        private readonly IShoppingCart _shoppingCart;
        private readonly ICosmeticsRepository _cosmeticsRepository;
        private readonly ICosmeticsTypeRepository _cosmeticsTypeRepository;

        public CosmeticsController(ICosmeticsRepository cosmeticsRepository, ICosmeticsTypeRepository cosmeticsTypeRepository, IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
            _cosmeticsRepository = cosmeticsRepository;
            _cosmeticsTypeRepository = cosmeticsTypeRepository;
        }


        public async Task<IActionResult> List(string cosmeticsType)
        {
            var selectedCosmeticsType = !string.IsNullOrWhiteSpace(cosmeticsType) ? cosmeticsType : null;
            var cosmeticsListViewModel = new CosmeticsListViewModel
            {
                Cosmetics = await _cosmeticsRepository.GetCosmetics(selectedCosmeticsType),
                CurrentCosmeticsType = selectedCosmeticsType ?? "All Cosmetics"
            };
            return View(cosmeticsListViewModel);
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> ChiTietSP(int id)
        {

            var cosmetics = await _cosmeticsRepository.GetCosmeticsById(id);

            return View(cosmetics);
        }
        public async Task<IActionResult> Makeup(string searchString, string sortOrder)
        {
            var cosmetics = await _cosmeticsRepository.GetAllCosmeticsNameId(searchString,sortOrder);
            return View(cosmetics);
        }
        [HttpGet("{CosmeticsType?}")]
        public async Task<IActionResult> Index(string searchString, string sortOrder)
        {
            var cosmetics = await _cosmeticsRepository.GetAllCosmeticsNameId(searchString, sortOrder);
            return View(cosmetics);
        }
        public IActionResult Blog()
        {
            return View();
        }
        public async Task<IActionResult> Tintuc()
        {
            return View();
        }
        public async Task<IActionResult> Muahang()
        {
            await _shoppingCart.GetShoppingCartItemsAsync();
            var shoppingCartCountTotal = await _shoppingCart.GetCartCountAndTotalAmmountAsync();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartItemsTotal = shoppingCartCountTotal.ItemCount,
                ShoppingCartTotal = shoppingCartCountTotal.TotalAmmount,
            };


            return View(shoppingCartViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddToShoppingCart(int cosmeticsId)
        {
            var selectedCosmetics = await _cosmeticsRepository.GetCosmeticsById(cosmeticsId);
            if (selectedCosmetics == null)
            {
                return NotFound();
            }

            await _shoppingCart.AddToCartAsync(selectedCosmetics);

            return RedirectToAction("Muahang");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromShoppingCart(int cosmeticsId)
        {
            var selectedCosmetics = await _cosmeticsRepository.GetCosmeticsById(cosmeticsId);
            if (selectedCosmetics == null)
            {
                return NotFound();
            }

            await _shoppingCart.RemoveFromCartAsync(selectedCosmetics);

            return RedirectToAction("Muahang");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAllCart()
        {
            await _shoppingCart.ClearCartAsync();
            return RedirectToAction("Muahang");
        }
        public async Task<IActionResult> Skincare(string searchString, string sortOrder)
        {
            var cosmetics = await _cosmeticsRepository.GetAllCosmeticsNameId(searchString, sortOrder);
            return View(cosmetics);
        }
        public async Task<IActionResult> Bodycare(string searchString, string sortOrder)
        {
            var cosmetics = await _cosmeticsRepository.GetAllCosmeticsNameId(searchString, sortOrder);
            return View(cosmetics);
        }
        public async Task<IActionResult> Perfume(string searchString, string sortOrder)
        {
            var cosmetics = await _cosmeticsRepository.GetAllCosmeticsNameId(searchString, sortOrder);
            return View(cosmetics);
        }
        public async Task<IActionResult> Hair(string searchString, string sortOrder)
        {
            var cosmetics = await _cosmeticsRepository.GetAllCosmeticsNameId(searchString, sortOrder);
            return View(cosmetics);
        }
    }
}
