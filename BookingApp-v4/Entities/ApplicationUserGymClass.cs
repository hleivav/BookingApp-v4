namespace BookingApp_v4.Entities
{
#nullable disable
    public class ApplicationUserGymClass
    {
        public string ApplicationUserId { get; set; } = string.Empty; 
        public int GymClassId { get; set; } 

        //nav prop
        public ApplicationUser ApplicationUser { get; set; }    
        public GymClass GymClass  { get; set; } 
    }
}
