namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TeamsHalf")]
    public class TeamsHalf
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string TeamId { get; set; }

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
        [StringLength(1)]
        public string Half { get; set; }

        [StringLength(1)]
        public string DivId { get; set; }

        [StringLength(1)]
        public string DivWin { get; set; }

        public short? Rank { get; set; }

        public short? G { get; set; }

        public short? W { get; set; }

        public short? L { get; set; }

        public virtual Team Teams { get; set; }
    }
}
