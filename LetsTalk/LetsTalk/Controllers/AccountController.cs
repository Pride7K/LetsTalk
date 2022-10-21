using System;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Dtos.AccountControllerDto;
using LetsTalk.Errors;
using LetsTalk.Extension.Methods;
using LetsTalk.Models;
using LetsTalk.Repositories.UserService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LetsTalk.Controllers
{
    [ApiController]
    [Route("Account")]
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;
        private SignInManager<User> _signInManager;

        public AccountController(IUserRepository _userRepository,SignInManager<User> signInManager)
        {
            this._userRepository = _userRepository;
            _signInManager = signInManager;
        }
        [HttpGet("Login")]
        public IActionResult Login() => View();
        
        [HttpGet("Register")]
        public IActionResult Register() => View();
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm]LoginRequestDto loginRequestDto)
        {
            try
            {
                var result = await _userRepository.Login(loginRequestDto.username, loginRequestDto.password);
                
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
        
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] RegisterRequestDto registerRequestDto)
        {
            try
            {
                var createdUser = await _userRepository.Create(registerRequestDto.username, registerRequestDto.password);

                if (!createdUser.Succeeded)
                    return RedirectToAction("Register", "Account");
                
                await _userRepository.Login(registerRequestDto.username, registerRequestDto.password);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return RedirectToAction("Register", "Account");
            }
        }
        
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}