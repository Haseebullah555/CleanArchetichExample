using Application.DTOs.Registeration;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticExample.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterDto registerDto)
        {
            return RedirectToAction(nameof(StudentController.AllStudents),"Student");
        }
    }
}
