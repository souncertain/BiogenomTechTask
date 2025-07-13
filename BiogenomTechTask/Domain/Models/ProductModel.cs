namespace BiogenomTechTask.Domain.Models
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public virtual List<Guid> VitaminsId { get; set; }
    }
}
