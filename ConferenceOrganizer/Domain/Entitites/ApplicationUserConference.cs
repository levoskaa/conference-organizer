namespace Domain.Entitites
{
    public class ApplicationUserConference
    {
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }
    }
}