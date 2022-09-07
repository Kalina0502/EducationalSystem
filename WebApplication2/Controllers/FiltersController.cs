using JustDiscustIt.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersController : ControllerBase
    {
        private EducationalSystemDbContext context;
        public FiltersController(EducationalSystemDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IEnumerable<FilteredUser> Post(string country)
        {
            return context.Users.Where(x => x.Country == country)
                .Select(x => new FilteredUser()
                {
                    UserName = x.UserName,
                    Email = x.Email,
                    Country = x.Country,
                    LanguageLevel = x.LanguageLevel,
                    Hobby = x.Hobby
                });
        }
    }
}
