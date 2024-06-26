﻿using Application.Contracts.Interfaces;
using Application.DTOs.Registeration;
using Application.Features.Registration.Request.Query;
using AutoMapper;
using Domain.IdentityEntities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticExample.Controllers
{
    [Route("[controller]/[action]")]
    [AllowAnonymous]
    public class AccountController(IMediator mediator,SignInManager<ApplicationUser> signInManager,UserManager<ApplicationUser> userManager, IMapper mapper,IUnitOfWork unitOfWork) : Controller
    {
        private readonly IMediator _mediator = mediator;
        private readonly SignInManager<ApplicationUser> _signInManager =  signInManager;
        private readonly UserManager<ApplicationUser> _userManager = userManager;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IMapper _mapper = mapper;
        //private readonly IUserRegisterationRepository _userRegisterationRepository = userRegisterationRepository;

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
                ViewBag.Errors = ModelState.Values.SelectMany(temp => temp.Errors).Select(temp => temp.ErrorMessage);
                return View(registerUserDto);
            }
            var user = _mapper.Map<ApplicationUser>(registerUserDto);
            //var user = new ApplicationUser 
            //{ 
            //    UserName = registerUserDto.UserName,
            //    Email = registerUserDto.Email,
            //    PhoneNumber = registerUserDto.PhoneNumber
            //};
            IdentityResult result = await _userManager.CreateAsync(user, registerUserDto.Password);
            _unitOfWork.Complete();
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("Register", error.Description);
                }
                return View(registerUserDto);
            }
            

            //    var CreateUser = new CreateUserCommand { User = registerUserDto };
            //    await _mediator.Send(CreateUser);
            //return RedirectToAction(nameof(HomeController.Index),"Home");
        }
        //public IActionResult Details(string id)
        //{
        //    var user = _userRegisterationRepository.GetById(id);
        //    return View(user);
        //}
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.Errors = ModelState.Values.SelectMany(temp => temp.Errors).Select(temp => temp.ErrorMessage);
                return View(loginDto);
            }
            var result = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, isPersistent:false, lockoutOnFailure: false);
            if(result.Succeeded)
            {
                return RedirectToAction(nameof(HomeController.Index),"Home");
            }
                ModelState.AddModelError("Login", "Invalid Email or Password");
            return View(loginDto);
            
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

    }
}
