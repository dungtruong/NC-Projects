using NaturalCosmetics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Interface
{
    public interface ICosmeticsTypeRepository
    {
        Task<IEnumerable<CosmeticsType>> GetCosmeticsType();
        
    }
}
