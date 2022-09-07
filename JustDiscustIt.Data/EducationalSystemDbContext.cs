using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace JustDiscustIt.Data
{
    public class EducationalSystemDbContext : DbContext
    {
        public EducationalSystemDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }

        //public DbSet<FreeTime> FreeTimes { get; set; }
    }
}
