using System;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Errors;
using LetsTalk.Models;
using LetsTalk.Repositories.UserService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LetsTalk.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AccountController(IUserRepository _userRepository)
        {
            this._userRepository = _userRepository;
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
                return result.Succeeded ?
                    RedirectToAction("Index","Home") 
                    : RedirectToAction("Login","Account");
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
        
        public async Task<IActionResult> Logout(string username,string password)
        {
            await _userRepository.Logout();
            
            return RedirectToAction("Login","Account");
        }
    }
}