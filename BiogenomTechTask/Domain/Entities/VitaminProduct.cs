using System.ComponentModel.DataAnnotations;

namespace BiogenomTechTask.Domain.Entities
{
    public class VitaminProduct
    {
        public Guid Id { get; set; }
        public Guid VitaminId { get; set; }
        public virtual Vitamin Vitamin { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public float VitaminContent { get; set; }
        [MaxLength(5)]
        public string Unit { get; set; }
    }
}
