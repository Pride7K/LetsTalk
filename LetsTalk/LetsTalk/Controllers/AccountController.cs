using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LetsTalk.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(AppDbContext _context,
            SignInManager<User> _signInManager,
            UserManager<User> _userManager)
        {
            this._context = _context;
            this._signInManager = _signInManager;
            this._userManager = _userManager;
        }
        [HttpGet]
        public IActionResult Login() => View();
        
        [HttpGet]
        public IActionResult Register() => View();
        [HttpPost]
        public async Task<IActionResult> Login(string username,string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
                return RedirectToAction("Login", "Account");
            var result = await _signInManager.PasswordSignInAsync(user,password,false,false);
            return result.Succeeded ?
                RedirectToAction("Index","Home") 
                : RedirectToAction("Login","Account");
        }
        [HttpPost]
        public async Task<IActionResult> Register(string username,string password)
        {

            var user = new User()
            {
                UserName = username,

            };
            
            var createdUser = await _userManager.CreateAsync(user,password);

            if (!createdUser.Succeeded)
                return RedirectToAction("Register", "Account");

            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }
        
        public async Task<IActionResult> Logout(string username,string password)
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login","Account");
        }
    }
}