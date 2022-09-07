using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services.Contracts;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IAccountService services;
        public LoginController(IAccountService services)
        {
            this.services = services;
        }

        [HttpPost]
        public JsonStatus Post(LoginModel loginModel)
        {
            return services.Login(loginModel, Request, Response);
        }
    }
}
