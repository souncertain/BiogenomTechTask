namespace BiogenomTechTask.Domain.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? Promocode { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public virtual List<Guid> ReportIds { get; set; }
    }
}
