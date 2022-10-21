using System;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Errors;
using LetsTalk.Extension.Methods;
using LetsTalk.Models;
using LetsTalk.Repositories.UserService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LetsTalk.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;
        private SignInManager<User> _signInManager;

        public AccountController(IUserRepository _userRepository,SignInManager<User> signInManager)
        {
            this._userRepository = _userRepository;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login() => View();
        
        [HttpGet]
        public IActionResult Register() => View();
        [HttpPost]
        public async Task<IActionResult> Login(string username,string password)
        {
            try
            {
                var result = await _userRepository.Login(username, password);
                
                if(!result.Succeeded)
                    return RedirectToAction("Login","Account");
                
                return RedirectToAction("Index", "Home");
            }
            catch (NotFoundException e)
            {
                return RedirectToAction("Login", "Account");
            }
            catch (Exception e)
            {
                return RedirectToAction("Login", "Account");
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(string username,string password)
        {
            try
            {
                var createdUser = await _userRepository.Create(username, password);

                if (!createdUser.Succeeded)
                    return RedirectToAction("Register", "Account");
                
                await _userRepository.Login(username, password);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return RedirectToAction("Register", "Account");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}