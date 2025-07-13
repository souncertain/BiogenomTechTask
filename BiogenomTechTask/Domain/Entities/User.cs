using System.ComponentModel.DataAnnotations;

namespace BiogenomTechTask.Domain.Entities
{
    public enum Gender
    {
        Male,
        Female
    }
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        [MaxLength(30)]
        public string? Promocode { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        [MaxLength(30)]
        public string? Email { get; set; }
        [MaxLength(15)]
        public string? Phone { get; set; }
        public virtual List<Report> Reports { get; set; }
    }
}
