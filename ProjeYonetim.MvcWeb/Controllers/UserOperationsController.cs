using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjeYonetim.MvcWeb.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.MvcWeb.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UserOperationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserOperationsController(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public async Task<IActionResult> Index()
        {
            ViewData["userRoles"] = await _context.UserRoles.ToListAsync();
            ViewData["roles"] = await _context.Roles.ToListAsync();
            var users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult AddOrUpdateUserRole(string id)
        {
            ViewData["user"] = _context.Users.FirstOrDefaultAsync(x => x.Id == id).Result.UserName;
            ViewData["roles"] = new SelectList(_roleManager.Roles, nameof(IdentityRole.Name), nameof(IdentityRole.Name));
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdateUserRole(string id, string roleName)
        {
            var user = await _userManager.FindByIdAsync(id);
            var userRole = await _context.UserRoles.FirstOrDefaultAsync(m => m.UserId == id);
            if (userRole != null)
            {
                var role = _context.Roles.FirstOrDefault(m => m.Id == userRole.RoleId);
                var delRoleToUser = await _userManager.RemoveFromRoleAsync(user, role.Name);
            }
            var addRoleToUser = await _userManager.AddToRoleAsync(user, roleName);

            return RedirectToAction(nameof(Index));
        }
    }
}
