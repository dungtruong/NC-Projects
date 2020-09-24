using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public int CosmeticsId { get; set; }
        public Cosmetics Cosmetics { get; set; }
        [Required]
        [StringLength(255)]
        public string ShoppingCartId { get; set; }
    }
}
