using Arabitey.Models;
using Arabitey.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Arabitey.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager
            , SignInManager<ApplicationUser> signInManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel newUser)//Customize property - validation atrbiute
        {
            if (ModelState.IsValid)
            {
                ApplicationUser UserModel = new ApplicationUser();
                UserModel.UserName = newUser.UserName;
                UserModel.Email = newUser.Email;
                UserModel.PasswordHash = newUser.Password;
                UserModel.National_ID = newUser.National_ID;
                UserModel.Address = newUser.Address;
                IdentityResult result =
                    await userManager.CreateAsync(UserModel, UserModel.PasswordHash);
                if (result.Succeeded)
                {
                    ClaimsIdentity claims = new ClaimsIdentity();
                    claims.AddClaim(new Claim("ID", UserModel.Id));
                    //create cookie
                    //signInManager.SignInWithClaimsAsync(UserModel, false, claims);
                    await signInManager.SignInAsync(UserModel, false);
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }
                //save 
            }
            return View(newUser);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel LoginAccount)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser UserModel =
                    await userManager.FindByNameAsync(LoginAccount.USerName);
                if (UserModel != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result =
                        await signInManager.PasswordSignInAsync
                        (UserModel, LoginAccount.Password, LoginAccount.isPersistent, false);
                    //don't forget Redirect
                    return RedirectToAction("Index","Home");//home page
                }
                else
                {
                    ModelState.AddModelError("", "Username & password Invalid");
                }
            }
            return View(LoginAccount);

        }
        /////////Register Admin///

        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> RegisterAdmin(RegisterViewModel newUser)//Customize property - validation atrbiute
        {
            if (ModelState.IsValid)
            {
                ApplicationUser UserModel = new ApplicationUser();
                UserModel.UserName = newUser.UserName;
                UserModel.Email = newUser.Email;
                UserModel.PasswordHash = newUser.Password;
                UserModel.National_ID = newUser.National_ID;
                UserModel.Address = newUser.Address;
                IdentityResult result =
                    await userManager.CreateAsync(UserModel, UserModel.PasswordHash);
                if (result.Succeeded)
                {
                    //Add to Role Admin
                    IdentityResult roleResult = await userManager.AddToRoleAsync(UserModel, "Admin");
                    if (roleResult.Succeeded)
                    {
                        //create cookie
                        await signInManager.SignInAsync(UserModel, false);
                        //don't forget redirect
                        return RedirectToAction("Index", "Home"); //dashboard related to admin
                    }
                    else
                    {
                        foreach (var item in roleResult.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }
                //save 
            }
            return View(newUser);
        }
    }
}
