using Microsoft.EntityFrameworkCore;
using NaturalCosmetics.Data;
using NaturalCosmetics.Interface;
using NaturalCosmetics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Repository
{
    public class CosmeticTypeRepository:ICosmeticsTypeRepository
    {
        private readonly DataContext _context;

        public CosmeticTypeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CosmeticsType>> GetCosmeticsType()
        {
            return await _context.cosmeticsTypes.ToListAsync();
        }
    }
}
