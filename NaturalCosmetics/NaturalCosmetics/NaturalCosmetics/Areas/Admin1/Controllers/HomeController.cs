using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NaturalCosmetics.Areas.Admin1.Models;
using NaturalCosmetics.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaturalCosmetics.Areas.Admin1.Controllers
{
    [Area("Admin1")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public HomeController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ListIdentityUser list = new ListIdentityUser()
            {
                ListUser = await _userManager.Users.ToListAsync()
            };
            List<List<String>> ListRole = new List<List<string>>();
            foreach(var item in list.ListUser)
            {
                var currentRole = await _userManager.GetRolesAsync(item);
                currentRole.Add(item.UserName);
                ListRole.Add(currentRole.ToList());
            }
            ViewBag.ListRole = ListRole;
            return View(list);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await AddRoleUser(RoleType.User, user);
                    return RedirectToLocal(returnUrl);
                }
                AddErrors(result);
            }
            // If we got this far, something failed, redisplay form
            return View(model);
        }
       
        private async Task AddRoleUser(RoleType type, IdentityUser user)
        {
            switch (type)
            {
                case RoleType.Admin:
                    await _userManager.AddToRoleAsync(user, "Admin ");
                    break;
                case RoleType.User:
                    await _userManager.AddToRoleAsync(user, "User");
                    break;
                case RoleType.HR:
                    await _userManager.AddToRoleAsync(user, "HR");
                    break;
            }
        }
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        //[HttpGet("edit/{id}")]
        //public async Task<IActionResult> Edit(string id)
        //{
        //    RegisterViewModel registerViewModel = new RegisterViewModel();
        //    return View(registerViewModel);
        //}
        //[HttpPost("edit/{id}")]
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Edit(string id,RegisterViewModel model,string email)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByIdAsync(id);
        //        var type = await _userManager.GetRolesAsync(user);
        //        user.UserName = model.Email;
        //        user.Email = model.Email;
                
        //        user.PasswordHash = model.Password;
                

        //        await _userManager.UpdateAsync(user);

                
        //    }
        //    // If we got this far, something failed, redisplay form
        //    return RedirectToAction("Index");
        //}
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCosmetics(string id)
        //{
        //    var user = await _userManager.FindByIdAsync(id);
        //    await _userManager.DeleteAsync(user);
            
        //    return Ok();
        //}
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Edit(int id, string returnUrl=null)
        {
            ListIdentityUser list = new ListIdentityUser()
            {
                ListUser = await _userManager.Users.ToListAsync(),
            };
            IdentityUser users = null;
            users = list.ListUser[id];
            ViewBag.ThisUser = users;
            var RoleOfUser = await _userManager.GetRolesAsync(users);
            ViewBag.RoleOfUser = RoleOfUser;
            ViewData["ReturnUrl"] = returnUrl;
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, RegisterViewModel model, string returnUrl )
        {
            ListIdentityUser list = new ListIdentityUser()
            {
                ListUser = await _userManager.Users.ToListAsync()
            };
            IdentityUser users = null;
            users = list.ListUser[id];
            ViewData["ReturnUrl"] = returnUrl;
            if (users != null)
            {
                users.Email = model.Email;
                var token = await _userManager.GenerateChangeEmailTokenAsync(users, model.Email);
                var result = await _userManager.ChangeEmailAsync(users,model.Email, token);
                var currentRole = await _userManager.GetRolesAsync(users);
                result = await _userManager.RemoveFromRoleAsync(users, currentRole[0]);
                result = await _userManager.AddToRoleAsync(users, model.Type.ToString());
                if (result.Succeeded)
                {
                    return RedirectToLocal(returnUrl);
                }
                AddErrors(result);
            }
            return View(model);
            

        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            ListIdentityUser list = new ListIdentityUser()
            {
                ListUser = await _userManager.Users.ToListAsync()
            };
            IdentityUser user = null;
            user = list.ListUser[id];
            var RoleOfUser = await _userManager.GetRolesAsync(user);
            await _userManager.DeleteAsync(user);
            await _userManager.RemoveFromRoleAsync(user, RoleOfUser[0]);
            return Ok();
        }


    }
}

