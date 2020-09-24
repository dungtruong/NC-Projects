using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NaturalCosmetics.Models;
using NaturalCosmetics.Repository;

namespace NaturalCosmetics.Repository
{
    public static class DbInitialize
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            string[] roleNames = { "Admin", "User", "HR" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName); if (!roleExist)
                {                     
                    //create the roles and seed them to the data base: Question 1                     
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            IdentityUser user = await UserManager.FindByEmailAsync("admin@gmail.com");
            if (user == null)
            {
                user = new IdentityUser() { UserName = "admin@gmail.com", Email = "admin@gmail.com", };
                await UserManager.CreateAsync(user, "Test@123");
            }
            await UserManager.AddToRoleAsync(user, "Admin");


            IdentityUser user1 = await UserManager.FindByEmailAsync("ttquynh@gmail.com");
            if (user1 == null)
            {
                user1 = new IdentityUser() { UserName = "ttquynh@gmail.com", Email = "ttquynh@gmail.com", };
                await UserManager.CreateAsync(user1, "Test@123");
            }
            await UserManager.AddToRoleAsync(user1, "User");
            IdentityUser user2 = await UserManager.FindByEmailAsync("ttquynh1@gmail.com");
            if (user2 == null)
            {
                user2 = new IdentityUser()
                {
                    UserName = "ttquynh1@gmail.com",
                    Email = "ttquynh1@gmail.com",
                }; await UserManager.CreateAsync(user2, "Test@123");
            }

            await UserManager.AddToRoleAsync(user2, "HR");
        }


        public static void Intialize(DataContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
        IConfiguration configuration)
        {
            var cosmeticsType = new List<CosmeticsType>
             {
                 new CosmeticsType{TypeName="Makeup"},
                 new CosmeticsType{TypeName="BodyCare"},
                 new CosmeticsType{TypeName="SkinCare"},
                 new CosmeticsType{TypeName="Hair"},
                 new CosmeticsType{TypeName="Perfume"}
             };
            var cosmetics = new List<Cosmetics>
            {
                new Cosmetics
                {
                    Name="Son moi",
                    Price=45000,
                    Detail="3ce",
                    CosmeticsTypes=cosmeticsType[0],
                    IsHotItems=true,

                }
            };
            if (!context.cosmeticsTypes.Any() && !context.cosmetics.Any())
            {
                context.cosmeticsTypes.AddRange(cosmeticsType);
                context.cosmetics.AddRange();
                context.SaveChanges();
            }
            context.SaveChanges();

            //IdentityUser usr = null;
            //string userEmail = configuration["Admin:Email"] ?? "admin@admin.com";
            //string userName = configuration["Admin:Username"] ?? "admin";
            //string password = configuration["Admin:Password"] ?? "Passw@rd!123";

            //if (!context.Users.Any())
            //{
            //    usr = new IdentityUser
            //    {
            //        Email = userEmail,
            //        UserName = userName
            //    };
            //    userManager.CreateAsync(usr, password);
            //}

            //if (!context.UserRoles.Any())
            //{
            //    roleManager.CreateAsync(new IdentityRole("Admin"));

            //}
            //if (usr == null)
            //{
            //    usr = userManager.FindByEmailAsync(userEmail).Result;
            //}
            //if (!userManager.IsInRoleAsync(usr, "Admin").Result)
            //{
            //    userManager.AddToRoleAsync(usr, "Admin");
            //}

            //context.SaveChanges();

            System.Console.WriteLine("Seeding... - End");
        }
    }
}