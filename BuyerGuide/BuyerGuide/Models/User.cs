using Microsoft.AspNetCore.Identity;

namespace BuyerGuide.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
    }
}
