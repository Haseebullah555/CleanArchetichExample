using Application.DTOs.Registeration;
using Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticExample.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager; 
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserRegisterDto registerDto)
        {
            if(ModelState.IsValid == false)
            {
                ViewBag.Error = ModelState.Values.SelectMany(temp => temp.Errors).Select(temp => temp.ErrorMessage);
                return View(registerDto);
            }
            ApplicationUser user = new ApplicationUser();
            return RedirectToAction(nameof(StudentController.AllStudents),"Student");
        }
    }
}
