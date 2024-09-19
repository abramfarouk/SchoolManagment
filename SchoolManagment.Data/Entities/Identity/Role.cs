using Microsoft.AspNetCore.Identity;

namespace SchoolManagment.Data.Entities.Identity
{
    public class Role : IdentityRole<int>
    {

        public string? Country { get; set; }
        public string? Address { get; set; }
    }
}
