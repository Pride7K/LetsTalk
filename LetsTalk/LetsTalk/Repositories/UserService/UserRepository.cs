using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Errors;
using LetsTalk.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LetsTalk.Repositories.UserService
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public UserRepository(AppDbContext _context,
            SignInManager<User> _signInManager,
            UserManager<User> _userManager)
        {
            this._context = _context;
            this._signInManager = _signInManager;
            this._userManager = _userManager;
        }
        public async Task<List<User>> GetUsersExceptSpecificUser(string userIdToNotMatch, CancellationToken token)
        {
            return await _context.User.Where(user => user.Id != userIdToNotMatch)
                .ToListAsync(cancellationToken:token);
        }

        public async Task<User> FindUserByName(string name)
        {
            return await _userManager.FindByNameAsync(name);
        }

        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Login(string username, string password)
        {
            
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                throw new NotFoundException("User not found!");

            return await _signInManager.PasswordSignInAsync(user,password,false,false);
        }

        public async Task<IdentityResult> Create(string username, string password)
        {
            var user = new User()
            {
                UserName = username,
            };
            
            var createdUser = await _userManager.CreateAsync(user,password);

            return createdUser;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}