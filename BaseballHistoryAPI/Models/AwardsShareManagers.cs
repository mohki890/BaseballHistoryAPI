namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AwardsShareManager
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string PlayerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string LgId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string AwardId { get; set; }

        public short? PointsWon { get; set; }

        public short? PointsMax { get; set; }

        public short? VotesFirst { get; set; }

        public virtual Master Master { get; set; }
    }
}
