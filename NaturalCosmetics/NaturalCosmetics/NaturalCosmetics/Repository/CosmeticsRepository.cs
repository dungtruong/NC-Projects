using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NaturalCosmetics.Core.Interface;
using NaturalCosmetics.Data;
using NaturalCosmetics.Dto;
using NaturalCosmetics.Interface;
using NaturalCosmetics.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Repository
{
    public class CosmeticsRepository : ICosmeticsRepository
    {
        private readonly DataContext _context;

        public CosmeticsRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Cosmetics> GetAllWithType()
        {
            return _context.cosmetics.Include(pt => pt.CosmeticsTypes);
        }
        public async Task<Cosmetics> GetCosmeticsById(int cosmeticsId)
        {
            return await _context.cosmetics.FirstAsync(e => e.Id == cosmeticsId);
        }


        public async Task<IEnumerable<Cosmetics>> GetCosmetics(string cosmeticstype = null)
        {

            var query = _context.cosmetics
                .Include(c => c.CosmeticsTypes)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(cosmeticstype))
            {
                query = query.Where(c => c.CosmeticsTypes.TypeName == cosmeticstype);
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Cosmetics>> GetHotItem()
        {
            return await _context.cosmetics
                .Where(e => e.IsHotItems)
                .Include(e => e.CosmeticsTypes)
                .ToListAsync();
        }
        public async Task<IEnumerable<CosmeticsDto>> GetAllCosmeticsNameId(string searchString, string sortOrder)
        {


            var cosmetics = from s in _context.cosmetics
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                return await _context.cosmetics
               .Where(e => e.Name.Contains(searchString))
               .AsNoTracking()
                .Select(e => new CosmeticsDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Img = e.Img,
                    Detail = e.Detail,
                    TypeId = e.TypeId,
                })
                .ToListAsync();
            }
            switch (sortOrder)
            {
                case "name_desc":
                    return await _context.cosmetics
                .AsNoTracking()
                .OrderByDescending(e => e.Name)
                 .Select(e => new CosmeticsDto
                 {
                     Id = e.Id,
                     Name = e.Name,
                     Price = e.Price,
                     Img = e.Img,
                     Detail = e.Detail,
                     TypeId = e.TypeId,
                 })
                 .ToListAsync();

                default:
                    return await
                        _context.cosmetics

                .AsNoTracking()
                .OrderBy(s => s.Name)

                 .Select(e => new CosmeticsDto
                 {
                     Id = e.Id,
                     Name = e.Name,
                     Price = e.Price,
                     Img = e.Img,
                     Detail = e.Detail,
                     TypeId = e.TypeId,
                 })
                 .ToListAsync();

            }
        }


        public void UpdateCosmetics(Cosmetics cosmetics)
        {
            _context.cosmetics.Update(cosmetics);
        }

        public async Task AddCosmeticsAsync(Cosmetics cosmetics)
        {
            await _context.cosmetics.AddAsync(cosmetics);
        }

        public void Delete(int id)
        {
            var cosmetics = new Cosmetics { Id = id };
            _context.Entry(cosmetics).State = EntityState.Deleted;
        }


    }
}
