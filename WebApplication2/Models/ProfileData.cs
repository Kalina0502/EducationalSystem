using JustDiscustIt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ProfileData
    {
        public string Country { get; set; }
        public string LanguageLevel { get; set; }
        public List<Hobby> Hobby { get; set; }
        public string Cookie { get; set; }
    }
}
