using Microsoft.AspNetCore.Identity;

namespace BookingApp_v4.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; } = new List<ApplicationUserGymClass>();
    }
}
