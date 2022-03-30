using Microsoft.AspNetCore.Identity;

namespace deneme12.Entity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
