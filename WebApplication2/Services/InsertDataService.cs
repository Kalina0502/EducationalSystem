using JustDiscustIt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class InsertDataService
    {
        private EducationalSystemDbContext context;
        public InsertDataService(EducationalSystemDbContext context)
        {
            this.context = context;
        }
        public JsonStatus SetData(ProfileData profileData)
        {
            List<User> list = context.Users.ToList();
            User dbUser = list.FirstOrDefault(x => Hash.GetHashSha256(x.Email) == profileData.Cookie);
            dbUser.Country = profileData.Country;
            dbUser.Hobby = profileData.Hobby;
            dbUser.LanguageLevel = profileData.LanguageLevel;
            context.SaveChanges();
            return new JsonStatus
            {
                Status = true
            };
        }
    }
}
