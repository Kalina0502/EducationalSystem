using JustDiscustIt.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Services.Contracts;

namespace WebApplication2.Controllers
{
    [Route("api/profile")]
    [ApiController]
    public class ProfileControler : ControllerBase
    {
        private IProfileService services;
        private EducationalSystemDbContext context;
        public ProfileControler(IProfileService services, EducationalSystemDbContext context)
        {
            this.services = services;
            this.context = context;
        }

        [HttpPost]
        public User Post(string userId, string cookie)
        {
            if (userId == null || int.Parse(userId) > context.Users.Count())
            {
                return services.GetLoggedUser(Request, cookie);
            }
            return services.GetUserById(userId);
        }
    }
}
