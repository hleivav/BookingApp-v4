namespace BookingApp_v4.Entities
{
    public class GymClass
    {
        public int Id { get; set; }    
        public string Name { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }    
        public TimeSpan Duration { get; set; } 
        public DateTime EndTime { get { return StartTime + Duration; } }  
        public string Description { get; set; } = String.Empty;
        //nav property
        public ICollection<ApplicationUserGymClass> attendedUsers { get; set; } = new List<ApplicationUserGymClass>();
    }
}
