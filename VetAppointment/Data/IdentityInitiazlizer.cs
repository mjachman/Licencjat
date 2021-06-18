using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetAppointment.Models.Identity;

namespace VetAppointment.Data
{
    public class IdentityInitializer
    {
        private RoleManager<IdentityRole> _roleMgr;
        private UserManager<AppUser> _userMgr;

        public IdentityInitializer(UserManager<AppUser> userMgr, RoleManager<IdentityRole> roleMgr)
        {
            _userMgr = userMgr;
            _roleMgr = roleMgr;
        }

        public async Task Seed()
        {

            await _roleMgr.CreateAsync(new IdentityRole("Admin"));
            await _roleMgr.CreateAsync(new IdentityRole("Vet"));
            await _roleMgr.CreateAsync(new IdentityRole("User"));
            var admin = new AppUser()
            {
                UserName = "test@admin.com",
                Name = "Admin",
                Surname = "User",
                Email = "test@admin.com",
                EmailConfirmed = true
            };
            var vet = new AppUser()
            {
                UserName = "vet@vet.pl",
                Name = "Wojciech",
                Surname = "Weterynarz",
                Email = "vet@vet.pl",
                Address = "Gdynia,ul. Kameliowa 34",
                EmailConfirmed = true
            };
            var vet2 = new AppUser()
            {
                UserName = "antoni.kujawkski@vet.pl",
                Name = "Antoni",
                Surname = "Kujawski",
                Email = "antoni.kujawkski@vet.pl",
                Address = "Sopot,ul. Haffnera 23",
                EmailConfirmed = true
            };
            var vet3 = new AppUser()
            {
                UserName = "kpawlicki@vet.pl",
                Name = "Krzysztof",
                Surname = "Pawlicki",
                Email = "kpawlicki@vet.pl",
                Address = "Gdańsk,ul. Potokowa 12",
                EmailConfirmed = true
            };
            var vet4 = new AppUser()
            {
                UserName = "pwalewski@vet.pl",
                Name = "Patryk",
                Surname = "Walewski",
                Email = "pwalewski@vet.pl",
                Address = "Wejherowo, ul Polna 18",
                EmailConfirmed = true
            };
            var user = new AppUser()
            {
                UserName = "annab@vet.pl",
                Name = "Anna",
                Surname = "Bromowska",
                Email = "annab@vet.pl",
                EmailConfirmed = true,
                Address = "Rumia,ul. Kwiatowa 10",
            };
            var user2 = new AppUser()
            {
                UserName = "szymon@szymon.pl",
                Name = "Szymon",
                Surname = "Kobol",
                Email = "szymon@szymon.pl",
                EmailConfirmed = true,
            };
            var user3 = new AppUser()
            {
                UserName = "artur@artur.pl",
                Name = "Artur",
                Surname = "Łata",
                Email = "artur@artur.pl",
                EmailConfirmed = true,
            };

            await _userMgr.CreateAsync(admin, "Admin1234");

            await _userMgr.CreateAsync(user, "User1234");
            await _userMgr.CreateAsync(user2, "User1234");
            await _userMgr.CreateAsync(user3, "User1234");

            await _userMgr.CreateAsync(vet, "Vet1234");
            await _userMgr.CreateAsync(vet2, "Vet1234");
            await _userMgr.CreateAsync(vet3, "Vet1234");
            await _userMgr.CreateAsync(vet4, "Vet12345");

            await _userMgr.AddToRoleAsync(vet4, "VET");
            await _userMgr.AddToRoleAsync(admin, "ADMIN");
            await _userMgr.AddToRoleAsync(user, "USER");
            await _userMgr.AddToRoleAsync(user2, "USER");
            await _userMgr.AddToRoleAsync(user3, "USER");

            await _userMgr.AddToRoleAsync(vet, "VET");
            await _userMgr.AddToRoleAsync(vet2, "VET");
            await _userMgr.AddToRoleAsync(vet3, "VET");


        }
    }
}
