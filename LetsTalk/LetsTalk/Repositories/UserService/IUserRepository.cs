using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Models;
using Microsoft.AspNetCore.Identity;

namespace LetsTalk.Repositories.UserService
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersExceptSpecificUser(string userIdToNotMatch, CancellationToken token);

        Task<User> FindUserByName(string name);
        
        Task<Microsoft.AspNetCore.Identity.SignInResult> Login(string username,string password);
        Task<IdentityResult> Create(string username,string password);

        Task Logout(string userId);
    }
}