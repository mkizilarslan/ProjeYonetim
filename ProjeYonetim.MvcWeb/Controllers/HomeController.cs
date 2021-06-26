using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjeYonetim.Data.Concrete.EFCore;
using ProjeYonetim.MvcWeb.Data;
using ProjeYonetim.MvcWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.MvcWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

#if DEBUG
            if (!_context.Users.Any())
            {
                var user = new IdentityUser { UserName = "Admin", NormalizedUserName = "ADMIN", Email = "admin@mksoft.com.tr", NormalizedEmail = "ADMIN@MKSOFT.COM.TR", EmailConfirmed = true, PhoneNumber = "01234567890", PasswordHash = "Aa.12345" };
                var result = await _userManager.CreateAsync(user, user.PasswordHash);
                if (result.Succeeded)
                {
                    var addRoleToUser = await _userManager.AddToRoleAsync(user, "Admin");
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var result1 = await _userManager.ConfirmEmailAsync(user, code);
                }
            }
            SeedDatabase.Seed();
#endif
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
