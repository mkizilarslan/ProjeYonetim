using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ProjeYonetim.MvcWeb.Data
{
    public class AdminCreated
    {
        public static async Task Seed(ApplicationDbContext _context, UserManager<IdentityUser> _userManager)
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
    }
}
