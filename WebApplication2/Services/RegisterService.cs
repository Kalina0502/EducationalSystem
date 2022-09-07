using JustDiscustIt.Data;
using Microsoft.AspNetCore.Http;
using System.Linq;
using WebApplication2.Models;
using WebApplication2.Services.Contracts;

namespace WebApplication2.Services
{
    public class RegisterService : IRegisterService
    {
        private EducationalSystemDbContext context;
        public RegisterService(EducationalSystemDbContext context)
        {
            this.context = context;
        }
        public JsonStatus Register(RegisterModel registerModel, HttpResponse response)
        {
            if (registerModel.ConfirmPassword != registerModel.Password)
            {
                return new JsonStatus
                {
                    Status = false
                };
            }
            if (context.Users.FirstOrDefault(x => x.Email == registerModel.Email) != null)
            {
                return new JsonStatus
                {
                    Status = false
                };
            }
            User user = new User()
            {
                Email = registerModel.Email,
                Password = Hash.GetHashSha256(registerModel.Password),
                UserName = registerModel.UserName
            };
            context.Users.Add(user);
            context.SaveChanges();

            return new JsonStatus
            {
                Status = true,
                HashEmail = Hash.GetHashSha256(registerModel.Email)
            };
        }
    }
}
