using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Errors;
using LetsTalk.Models;
using LetsTalk.Transaction;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LetsTalk.Repositories.UserService
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _uow;

        public UserRepository(AppDbContext _context,
            SignInManager<User> _signInManager,
            UserManager<User> _userManager,
            IUnitOfWork uow)
        {
            this._context = _context;
            this._signInManager = _signInManager;
            this._userManager = _userManager;
            _uow = uow;
        }
        public async Task<List<User>> GetUsersExceptSpecificUser(string userIdToNotMatch, CancellationToken token)
        {
            return await _context.User.Where(user => user.Id != userIdToNotMatch && user.IsOnline)
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

            var result = await _signInManager.PasswordSignInAsync(user, password, false, false);

            if (!result.Succeeded)
                return result;

            user.IsOnline = true;
            await _uow.Commit(CancellationToken.None);    
            
            
            return result;
        }

        public async Task<IdentityResult> Create(string username, string password)
        {
            var userDb = await _userManager.FindByNameAsync(username);
            if (userDb != null)
                throw new AlreadyExistsException("User already Exists!");
            
            var user = new User()
            {
                UserName = username,
            };
            
            var createdUser = await _userManager.CreateAsync(user,password);

            return createdUser;
        }

        public async Task Logout(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            user.IsOnline = false;

            await _uow.Commit(CancellationToken.None);   
            
            await _signInManager.SignOutAsync();
        }
    }
}