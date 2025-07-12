using System.ComponentModel.DataAnnotations;

namespace BiogenomTechTask.Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(350)]
        public string Description { get; set; }
        [MaxLength(350)]
        public string Note { get; set; }
        public virtual List<VitaminProduct> VitaminProducts { get; set; }
    }
}
