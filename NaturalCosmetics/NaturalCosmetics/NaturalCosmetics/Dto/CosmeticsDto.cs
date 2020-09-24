using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Dto
{
    public class CosmeticsDto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Cosmetics Name")]
        public string Name { get; set; }

        

        [Required]
        [Display(Name = "Detail")]
        [MaxLength(255)]
        public string Detail { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Img { get; set; }

        [Display(Name = "Is Cosmetics hot item? ")]
        public bool IsHotItems { get; set; }

        [Display(Name = "Cosmetics Type")]
        public int TypeId { get; set; }
    }
}
