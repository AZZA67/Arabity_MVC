using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Arabitey.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string RoleName)
        {
            if (RoleName != null)
            {
                IdentityRole role = new IdentityRole();
                role.Name = RoleName;
                IdentityResult result = await roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Car");
                }
                else
                {
                    ViewData["Error"] = result.Errors;
                }
            }
            ViewData["RoleName"] = RoleName;
            return View();
        }

    }
}
