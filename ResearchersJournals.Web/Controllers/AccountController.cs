using ResearchersJournals.Web.Entities;
using ResearchersJournals.Web.Infrastructure.Repositories.AccountRepository.Account;
using ResearchersJournals.Web.Models.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using ResearchersJournals.Web.Models.Security;

namespace ResearchersJournals.Web.Controllers
{
    public class AccountController : Controller
    {
        private IAccountRepository accountRepository { get; set; }
        private readonly ILogger<AccountController> _logger;
        public AccountController(IAccountRepository _accountRepository, ILogger<AccountController> logger)
        {
            this.accountRepository = _accountRepository;
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                var researcher = accountRepository.AuthenticateResearcher(model.UserName, model.Password);
                if (researcher == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    return View();
                }

          
                var claims = new List<Claim>
             {
                 new Claim(ClaimTypes.Name, researcher.Name),
                
                 new Claim(ClaimTypes.Email , researcher.Email),
                   new Claim("ResearcherId" , researcher.Id.ToString())
                 
            };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
              

                await HttpContext.SignInAsync(
                   CookieAuthenticationDefaults.AuthenticationScheme,
                   new ClaimsPrincipal(claimsIdentity),
                   new AuthenticationProperties
                   {
                       AllowRefresh = true,
                       ExpiresUtc = DateTimeOffset.Now.AddDays(1),
                       IsPersistent = true,
                   });
                return RedirectToAction("JournalsDocuments", "Document");
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                return View();

            }
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            try
            {
                accountRepository.RegisterResearcher(new Entities.Researcher
                {
                    Name = model.Name,
                    Password = model.Password,
                    UserName = model.UserName,
                    Email = model.Email,
                });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred registering the Researcher : " + ex.Message);
                return View();
            }

            return RedirectToAction("Login");

        }
        private Researcher Authenticate(LoginViewModel model)
        {
            var researcher = accountRepository.AuthenticateResearcher(model.UserName, model.Password);
            return researcher;
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
