using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using NaturalCosmetics.Interface;
using NaturalCosmetics.ViewModels;

namespace NaturalCosmetics.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICosmeticsRepository _cosmeticsRepository;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(ICosmeticsRepository cosmeticsRepository, IShoppingCart shoppingCart)
        {
            _cosmeticsRepository = cosmeticsRepository;
            _shoppingCart = shoppingCart;
        }

        public async Task<IActionResult> Index()
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

            return RedirectToAction("Index");
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

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAllCart()
        {
            await _shoppingCart.ClearCartAsync();
            return RedirectToAction("Index");
        }
    }
}