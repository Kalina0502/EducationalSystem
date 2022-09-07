using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.Contracts
{
    public interface IAccountService
    {
        public JsonStatus Login(LoginModel loginModel, HttpRequest request, HttpResponse response);
    }
}
