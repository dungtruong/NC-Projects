using Microsoft.AspNetCore.Http;
using NaturalCosmetics.Models;
using NaturalCosmetics.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Interface
{
    public interface ICosmeticsRepository
    {
        IEnumerable<Cosmetics> GetAllWithType();
        Task<IEnumerable<Cosmetics>> GetCosmetics(string category = null);
        Task<IEnumerable<Cosmetics>> GetHotItem();
        Task<Cosmetics> GetCosmeticsById(int cakeId);

        Task<IEnumerable<CosmeticsDto>> GetAllCosmeticsNameId(string searchString, string sortOrder);

        void Delete(int id);
        Task AddCosmeticsAsync(Cosmetics cosmetics);
        void UpdateCosmetics(Cosmetics cosmetics);
    }
}
