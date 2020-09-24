
using NaturalCosmetics.Dto;
using NaturalCosmetics.Models;
using System.Collections.Generic;

namespace NaturalCosmetics.ViewModels
{
    public class CosmeticsCreateUpdateViewModel
    {
        public IEnumerable<CosmeticsType> CosmeticsTypes { get; set; }
        public CosmeticsDto CosmeticsDto { get; set; }
        public CosmeticsCreateUpdateViewModel()
        {
            CosmeticsTypes = new List<CosmeticsType>();
        }
    }
}
