using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlitzStep.Web.Data
{
    public class User : IdentityUser
    {
        public string Password { get; set; }
        public int Points { get; set; }
        public int Age { get; set; }
        //TODO //public ICollection<Enum> MyProperty { get; set; }
    }
}