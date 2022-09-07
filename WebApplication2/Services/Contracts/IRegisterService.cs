using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.Contracts 
{
    public interface IRegisterService
    {
        public JsonStatus Register(RegisterModel registerModel, HttpResponse response);
    }
}
