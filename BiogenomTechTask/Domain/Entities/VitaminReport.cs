namespace BiogenomTechTask.Domain.Entities
{
    public class VitaminReport
    {
        public Guid Id { get; set; }
        public Guid IdVitamin { get; set; }
        public virtual Vitamin Vitamin { get; set; }
        public Guid IdReport { get; set; }
        public virtual Report Report { get; set; }
    }
}
