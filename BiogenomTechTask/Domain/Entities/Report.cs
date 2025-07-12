namespace BiogenomTechTask.Domain.Entities
{
    public class Report
    {
        public Guid Id { get; set; }
        public DateOnly Created {  get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<VitaminReport> VitaminReports { get; set; }
    }
}
