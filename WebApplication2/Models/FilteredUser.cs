using JustDiscustIt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class FilteredUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string LanguageLevel { get; set; }
        public ICollection<Hobby> Hobby { get; set; }
    }
}
