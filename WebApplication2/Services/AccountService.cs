using JustDiscustIt.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;
using WebApplication2.Services.Contracts;

namespace WebApplication2.Services
{
    public class AccountService : IAccountService
    {
        private EducationalSystemDbContext context { get; set; }
        public AccountService(EducationalSystemDbContext context)
        {
            this.context = context;
        }
        public JsonStatus Login(LoginModel loginModel, HttpRequest request, HttpResponse response)
        {
            List<User> list = context.Users.ToList();
            if (list.FirstOrDefault(x => x.Email == loginModel.Email) == null)
            {
                return new JsonStatus
                {
                    Status = false
                };
            }
            else if (request.Cookies["auth"] == null)
            {
                return new JsonStatus
                {
                    Status = true,
                    HashEmail = Hash.GetHashSha256(loginModel.Email)
                };
            }
            else if (Hash.GetHashSha256(loginModel.Password) != list.FirstOrDefault(x => x.Email == loginModel.Email).Password)
            {
                return new JsonStatus
                {
                    Status = false
                };
            }
            //response.Cookies.Append("auth", Hash.GetHashSha256(loginModel.Email),
            //new CookieOptions() { SameSite = SameSiteMode.None });
            return new JsonStatus
            {
                Status = true
            };
        }
    }
}