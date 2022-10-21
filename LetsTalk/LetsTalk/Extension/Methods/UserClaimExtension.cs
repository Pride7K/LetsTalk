using System.Security.Claims;

namespace LetsTalk.Extension.Methods
{
    public static class UserClaimExtension
    {
        public static string GetUserId(this ClaimsPrincipal User)
        {
            return User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}