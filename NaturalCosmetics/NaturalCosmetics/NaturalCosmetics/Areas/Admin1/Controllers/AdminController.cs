using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NaturalCosmetics.Areas.Admin1.Models;
using NaturalCosmetics.Core.Interface;
using NaturalCosmetics.Dto;
using NaturalCosmetics.Interface;
using NaturalCosmetics.Models;
using NaturalCosmetics.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Areas.Admin1.Controllers
{
    [Area("Admin1")]
    [Authorize(Roles = "Admin")]
    [Route("/admin/")]
    public class AdminController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICosmeticsRepository _cosmeticsRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICosmeticsTypeRepository _cosmeticsTypeRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(
            UserManager<IdentityUser> userManager,
            IOrderRepository orderRepository,
            ICosmeticsRepository cosmeticsRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ICosmeticsTypeRepository cosmeticsTypeRepository)
        {
            _userManager = userManager;
            _orderRepository = orderRepository;
            _cosmeticsRepository = cosmeticsRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _cosmeticsTypeRepository = cosmeticsTypeRepository;
        }

        [HttpGet("allOrders")]
        public async Task<IActionResult> AllOrder()
        {
            ViewBag.ActionTitle = "All Orders";
            var orders = await _orderRepository.GetAllOrdersAsync();
            return View(orders);
        }
        [HttpGet("")]
        public IActionResult Index(string searchString, string sortOrder, string currentFilter, int? page)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CurrentSort"] = sortOrder;

            //var cosmetics = await _cosmeticsRepository.GetAllCosmeticsNameId(searchString, sortOrder);
            //return View(cosmetics);
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            //Database model = new Database()
            //{
            //    // Cheeses = CheeseData.GetAll()
            //    Cheeses = _database.Cheeses
            //};
            List<Cosmetics> ListSearchProduct = new List<Cosmetics>();
            ListSearchProduct = _cosmeticsRepository.GetAllWithType().ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                ListSearchProduct = ListSearchProduct.Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();
            }
            switch (sortOrder)
            {
                case "name_desc":
                    ListSearchProduct = ListSearchProduct.OrderByDescending(s => s.Name).ToList();
                    break;
                case "price_desc":
                    ListSearchProduct.OrderByDescending(s => s.Price).ToList();
                    break;
                    //case "year_desc":
                    //    model.Cheeses.OrderByDescending(s => s.Name);
                    //    break;
            }
            int pageSize = 5;
            return View(PaginatedListProduct<Cosmetics>.Create(ListSearchProduct.AsQueryable(), page ?? 1, pageSize));
        }

        [HttpGet("add")]
        public async Task<IActionResult> Add()
        {
            var cosmeticsTypes = await _cosmeticsTypeRepository.GetCosmeticsType();
            return View(new CosmeticsCreateUpdateViewModel
            {
                CosmeticsTypes = cosmeticsTypes
            });
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(CosmeticsDto cosmeticsDto, IFormFile photo)
        {
            if (!ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/upload", photo.FileName);
                FileStream stream = new FileStream(path, FileMode.Create);
                await photo.CopyToAsync(stream);
                cosmeticsDto.Img = photo.FileName;
                var cosmeticsTypes = await _cosmeticsTypeRepository.GetCosmeticsType();
                return View(new CosmeticsCreateUpdateViewModel
                {
                    CosmeticsDto = cosmeticsDto,
                    CosmeticsTypes = cosmeticsTypes
                });
            }
            var cosmetics = _mapper.Map<CosmeticsDto, Cosmetics>(cosmeticsDto);
            await _cosmeticsRepository.AddCosmeticsAsync(cosmetics);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }
    

    [HttpGet("edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {

            var cosmetics = await _cosmeticsRepository.GetCosmeticsById(id);
            var cosmeticsDto = _mapper.Map<Cosmetics, CosmeticsDto>(cosmetics);
            var cosmeticsType = await _cosmeticsTypeRepository.GetCosmeticsType();

            return View(new CosmeticsCreateUpdateViewModel
            {
                CosmeticsTypes = cosmeticsType,
                CosmeticsDto = cosmeticsDto
            });
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromForm]CosmeticsDto cosmeticsDto, IFormFile photo)
        {
            if (!ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/upload", photo.FileName);
                FileStream stream = new FileStream(path, FileMode.Create);
                await photo.CopyToAsync(stream);
                cosmeticsDto.Img = photo.FileName;
                var cosmeticsTypes = await _cosmeticsTypeRepository.GetCosmeticsType();
                return View(new CosmeticsCreateUpdateViewModel
                {
                    CosmeticsDto = cosmeticsDto,
                    CosmeticsTypes = cosmeticsTypes
                });
            }
            var cosmetics = _mapper.Map<CosmeticsDto, Cosmetics>(cosmeticsDto);
            cosmetics.Id = id;
            _cosmeticsRepository.UpdateCosmetics(cosmetics);
            await _unitOfWork.CompleteAsync();

            return RedirectToAction("Index");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _cosmeticsRepository.Delete(id);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }
        [Route("/admin/index1")]
        public async Task<IActionResult> Index1(DashboardViewModel dashboardViewModel)
        {

            //ListIdentityUser list = new ListIdentityUser()
            //{
            //    ListUser = await _userManager.Users.ToListAsync()
            //};
            dashboardViewModel.ListUser = await _userManager.Users.ToListAsync();
            dashboardViewModel.myOrderViewModels = await _orderRepository.GetAllOrdersAsync();
           
          
            return View(dashboardViewModel);
        }
        //[HttpGet("dashboard")]
        //public async Task<IActionResult> Dashboard()
        //{
        //    DashboardViewModel dashboard= new DashboardViewModel();
        //    dashboard.makeup_count=await 
        //}

    }
}