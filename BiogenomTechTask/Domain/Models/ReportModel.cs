namespace BiogenomTechTask.Domain.Models
{
    public class ReportModel
    {
        public DateOnly Created { get; set; }
        public Guid UserId { get; set; }
        public virtual List<Guid> VitaminsId { get; set; }
    }
}
