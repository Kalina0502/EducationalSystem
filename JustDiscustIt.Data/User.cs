using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JustDiscustIt.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string LanguageLevel { get; set; }
        public ICollection<Hobby> Hobby { get; set; } = new List<Hobby>();

        //public ICollection<FreeTime> FreeTimes { get; set; }
    }
}
