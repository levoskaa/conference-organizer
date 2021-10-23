namespace Domain.Entitites
{
    public class ApplicationUserProfessionalField
    {
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int FieldId { get; set; }
        public ProfessionalField Field { get; set; }
    }
}