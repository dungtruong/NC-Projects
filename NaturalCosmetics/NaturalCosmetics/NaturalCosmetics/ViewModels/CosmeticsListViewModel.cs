
using NaturalCosmetics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.ViewModels
{
    public class CosmeticsListViewModel
    {
        public IEnumerable<Cosmetics> Cosmetics { get; set; }
        public string CurrentCosmeticsType { get; set; }
    }
}
