using JustDiscustIt.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileInsert : ControllerBase
    {
        private InsertDataService services;
        public ProfileInsert(InsertDataService services)
        {
            this.services = services;
        }

        [HttpPost]
        public JsonStatus Post(ProfileData profileData)
        {
           return services.SetData(profileData);
        }
    }
}
