using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlitzStep.Web.Data
{
    public class EducationalSystemDbContext : IdentityDbContext
    {
        public EducationalSystemDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}