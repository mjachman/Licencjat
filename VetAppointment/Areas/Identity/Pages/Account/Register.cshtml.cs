using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using VetAppointment.Models.Identity;
using VetAppointment.Services;

namespace VetAppointment.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;
        //private readonly IEmailSender _emailSender;
        private readonly IMailService _mailService;
        public RegisterModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            ILogger<RegisterModel> logger,
            //IEmailSender emailSender
            IMailService mailService
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mailService = mailService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        //public VetInputModel VetInput { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Imię wymagane")]
            [Display(Name = "Imię")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Nazwisko wymagane")]
            [Display(Name = "Nazwisko")]
            public string Surname { get; set; }

            [Required(ErrorMessage = "E-mail wymagany")]
            [EmailAddress(ErrorMessage = "Niepoprawny format e-maila")]
            [Display(Name = "E-mail")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Hasło wymagane")]
            [StringLength(100, ErrorMessage = "Minimalna długość hasła: {2}", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Hasło")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Powtórz hasło")]
            [Compare("Password", ErrorMessage = "Hasła różnią się od siebie.")]
            public string ConfirmPassword { get; set; }
            public bool Vet { get; set; }

            [Required(ErrorMessage = "Adres wymagany")]
            [Display(Name = "Adres")]
            public string Address { get; set; }

            [DataType(DataType.PhoneNumber)]
            [Required(ErrorMessage = "Numer telefonu wymagany")]
            [Display(Name = "Numer telefonu")]
            public string PhoneNumber { get; set; }

        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new AppUser { UserName = Input.Email, Email = Input.Email,Name=Input.Name, Surname=Input.Surname };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if(Input.Vet)
                {
                    await _userManager.AddToRoleAsync(user, "Vet");
                }
                else
                {
                    await _userManager.AddToRoleAsync(user, "User");
                }
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _mailService.SendEmailAsync(Input.Email, "Aktywacja konta w aplikacji weterynaryjnej",
                        $"Link aktywujący konto '{callbackUrl}'");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }

    }
}
