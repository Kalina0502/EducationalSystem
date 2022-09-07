using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services.Contracts;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private IRegisterService services;
        public RegisterController(IRegisterService services)
        {
            this.services = services;
        }

        [HttpPost]
        public JsonStatus Post(RegisterModel registerModel)
        {
            return services.Register(registerModel, Response);
        }
    }
}