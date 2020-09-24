using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using NaturalCosmetics.Interface;
using NaturalCosmetics.Dto;
using NaturalCosmetics.Models;

namespace NaturalCosmetics.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IShoppingCart _shoppingCart;
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderController(
            IShoppingCart shoppingCart,
            IMapper mapper,
            IOrderRepository orderRepository)
        {
            _shoppingCart = shoppingCart;
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<IActionResult> Checkout()
        {
            var cartItems = await _shoppingCart.GetShoppingCartItemsAsync();
            if (cartItems?.Count() <= 0)
            {
                return Redirect("/shoppingcart");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout([FromForm]OrderDto orderDto)
        {
            if (!ModelState.IsValid)
            {
                return View(orderDto);
            }

            var cartItems = await _shoppingCart.GetShoppingCartItemsAsync();

            if (cartItems?.Count() <= 0)
            {
                ModelState.AddModelError("", "Your Cart is empty. Please add some cakes before checkout");
                return View(orderDto);
            }

            var order = _mapper.Map<OrderDto, Order>(orderDto);
            order.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _orderRepository.CreateOrderAsync(order);

            await _shoppingCart.ClearCartAsync();


            return View("CheckoutComplete");
        }


        public async Task<IActionResult> MyOrder()
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = await _orderRepository.GetAllOrdersAsync(userId);
            return View(orders);
        }
    }
}