using JustDiscustIt.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Services.Contracts;

namespace WebApplication2.Services
{
    public class ProfileService : IProfileService
    {
        private EducationalSystemDbContext context { get; set; }
        public ProfileService(EducationalSystemDbContext context)
        {
            this.context = context;
        }
        public User GetLoggedUser(HttpRequest request, string cookie)
        {
            if (cookie == null)
            {
                return null;
            }

            List<User> list = context.Users.ToList();

            return list.FirstOrDefault(x => Hash.GetHashSha256(x.Email) == cookie);
        }

        public User GetUserById(string userId)
        {
            List<User> list = context.Users.ToList();

            return list.FirstOrDefault(x => x.Id == int.Parse(userId));
        }
    }
}