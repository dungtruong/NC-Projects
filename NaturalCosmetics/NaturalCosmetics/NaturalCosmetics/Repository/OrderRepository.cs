using Microsoft.EntityFrameworkCore;
using NaturalCosmetics.Data;
using NaturalCosmetics.Dto;
using NaturalCosmetics.Interface;
using NaturalCosmetics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaturalCosmetics.ViewModels;

namespace NaturalCosmetics.Repository
{
    public class OrderRepository: IOrderRepository
    {
        private readonly DataContext _context;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(DataContext context,IShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }

        public async Task CreateOrderAsync(Order order)
        {
            order.OrderPlacedTime = DateTime.Now;
            await _context.Orders.AddAsync(order);

            var shoppingCartItems = await _shoppingCart.GetShoppingCartItemsAsync();
            order.OrderTotal = (await _shoppingCart.GetCartCountAndTotalAmmountAsync()).TotalAmmount;

            await _context.OrderDetails.AddRangeAsync(shoppingCartItems.Select(e => new OrderDetail
            {
                Qty = e.Qty,
                CosmeticsName = e.Cosmetics.Name,
                OrderId = order.Id,
                Price = e.Cosmetics.Price
            }));

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<MyOrderViewModel>> GetAllOrdersAsync()
        {
            return await _context.Orders
                .Include(e => e.OrderDetails)
                .Select(e => new MyOrderViewModel
                {
                    OrderPlacedTime = e.OrderPlacedTime,
                    OrderTotal = e.OrderTotal,
                    OrderPlaceDetails = new OrderDto
                    {
                        AddressLine1 = e.AddressLine1,
                        
                        Email = e.Email,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        PhoneNumber = e.PhoneNumber,
                       
                    },
                    CosmeticsOrderInfos = e.OrderDetails.Select(o => new MyCosmeticsOrderInfo
                    {
                        Name = o.CosmeticsName,
                        Price = o.Price,
                        Qty = o.Qty
                    })
                })
                .ToListAsync();

        }
        public async Task<IEnumerable<MyOrderViewModel>> GetAllOrdersAsync(string userId)
        {
            return await _context.Orders
                .Where(e => e.UserId == userId)
                .Include(e => e.OrderDetails)
                .Select(e => new MyOrderViewModel
                {
                    OrderPlacedTime = e.OrderPlacedTime,
                    OrderTotal = e.OrderTotal,
                    OrderPlaceDetails = new OrderDto
                    {
                        AddressLine1 = e.AddressLine1,
                       
                        Email = e.Email,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        PhoneNumber = e.PhoneNumber,
                        
                    },
                    CosmeticsOrderInfos = e.OrderDetails.Select(o => new MyCosmeticsOrderInfo
                    {
                        Name = o.CosmeticsName,
                        Price = o.Price,
                        Qty = o.Qty
                    })
                })
                .ToListAsync();
        }
    }
}
