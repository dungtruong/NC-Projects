using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Models
{
    public class Cosmetics
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public decimal Price { get; set; }
        [Required]
        [StringLength(255)]
        public string Detail { get; set; }
        [Required]
        [StringLength(255)]
        public string Img { get; set; }

        [Required]
        [StringLength(255)]
        public bool IsHotItems { get; set; }

        public int TypeId { get; set; }
        public virtual CosmeticsType CosmeticsTypes { get; set; }

    }

}
