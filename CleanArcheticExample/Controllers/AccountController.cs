using Application.DTOs.Registeration;
using Application.Features.Registration.Request.Command;
using Application.Features.Registration.Request.Query;
using Domain.IdentityEntities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticExample.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController(IMediator mediator) : Controller
    {
        private readonly IMediator _mediator = mediator;

        public async Task<IActionResult> Index()
        {
            var users = await _mediator.Send(new GetAllUserRequest());
            return View(users);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDto registerUserDto)
        {
            if (ModelState.IsValid == false)
            {
               return NotFound();
            }
            var CreateUser = new CreateUserCommand { User = registerUserDto };
            await _mediator.Send(CreateUser);
            return RedirectToAction("Index");
        }
    }
}
