using JustDiscustIt.Data;
using Microsoft.AspNetCore.Http;

namespace WebApplication2.Services.Contracts
{
    public interface IProfileService
    {
        public User GetLoggedUser(HttpRequest request, string cookie);
        public User GetUserById(string userId);
    }
}
