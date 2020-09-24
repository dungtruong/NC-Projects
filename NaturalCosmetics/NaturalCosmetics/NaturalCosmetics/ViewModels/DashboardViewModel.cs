using Microsoft.AspNetCore.Identity;
using NaturalCosmetics.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.ViewModels
{
    public class DashboardViewModel
    {
        //public class MyOrderViewModel
        //{
        //    public OrderDto OrderPlaceDetails { get; set; }
        //    public decimal OrderTotal { get; set; }
        //    public DateTime OrderPlacedTime { get; set; }
        //    public IEnumerable<MyCosmeticsOrderInfo> CosmeticsOrderInfos { get; set; }
        //}
        //public class MyCosmeticsOrderInfo
        //{
        //    public int Qty { get; set; }
        //    public decimal Price { get; set; }
        //    public string Name { get; set; }
        //}
        public IEnumerable<MyOrderViewModel> myOrderViewModels { get; set; }
        public List<IdentityUser> ListUser { get; set; }
        public DateTime OrderPlacedTime { get; set; }
        public int a { get; set; }
    }
}
