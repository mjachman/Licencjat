using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VetAppointment.Models.Identity;
using VetAppointment.Models;
using Microsoft.AspNetCore.Identity;

namespace VetAppointment.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Pet> Pets { get; set; }

        public DbSet<Entry> Entries { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppUser> AppUsers { get; set; }
        //private UserManager<AppUser> _userMgr;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        //    AppUser Admin = new AppUser
        //    {
        //        Name = "Admin",
        //        Email = "admin@admin.com",
        //        NormalizedEmail = "admin@admin.com",
        //        UserName = "admin@admin.com",
        //        EmailConfirmed = true,

        //    };
        //    AppUser User = new AppUser
        //    {
        //        Name = "Karol",
        //        Surname = "Baczyna",
        //        Email = "karol@karol.pl",
        //        NormalizedEmail = "karol@karol.pl",
        //        UserName = "karol@karol.pl",
        //        EmailConfirmed = true,
        //    };
        //    AppUser Vet = new AppUser
        //    {
        //        Name = "Artur",
        //        Surname = "Głowacki",
        //        Email = "wet@wet.pl",
        //        NormalizedEmail = "wet@wet.pl",
        //        UserName = "wet@wet.pl",
        //        EmailConfirmed = true,
        //        Address = "Gdynia,ul. Rdestowa 15"
        //    };
        //    PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
        //    Admin.PasswordHash = ph.HashPassword(Admin, "admin1234");
        //    Vet.PasswordHash = ph.HashPassword(Vet, "vet1234");
        //    User.PasswordHash = ph.HashPassword(User, "user1234");

        //    builder.Entity<IdentityRole>().HasData(
        //     new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
        //     new IdentityRole { Name = "User", NormalizedName = "USER" },
        //     new IdentityRole { Name = "Vet", NormalizedName = "VET" }
        // );
           
        //    builder.Entity<AppUser>().HasData(
        //    Admin,
        //    Vet,
        //    User
        //);
        //    _userMgr.AddToRoleAsync(User, "Admin");
        //    _userMgr.AddToRoleAsync(Vet, "Vet");
        //    _userMgr.AddToRoleAsync(Admin, "Admin");
            //builder.Entity<IdentityRole>().HasData(new IdentityRole() { RoleId = 2147483645, UserId = 2147483646 });
            // Customize the ASP.NET Core Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Core Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
