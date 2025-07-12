using System.ComponentModel.DataAnnotations;

namespace BiogenomTechTask.Domain.Entities
{
    public class Vitamin
    {
        public Guid Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(5)]
        public string Unit { get; set; }
        public float DailyStandart { get; set; }
        public float DailyUserVolume { get; set; }
        [MaxLength(350)]
        public string EffectsOnTheBody { get; set; }
        [MaxLength(350)]
        public string NutrionRecommendations { get; set; }
        public virtual List<VitaminReport> VitaminReports { get; set; }
        public virtual List<VitaminProduct> VitaminProduct { get; set; }

    }
}
