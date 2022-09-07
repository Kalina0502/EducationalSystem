using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public IEnumerable<string> Post()
        {
            return new List<string>()
            {
                "traveling",
                "drawing",
                "sports"
            };
        }
    }
}
