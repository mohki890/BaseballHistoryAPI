namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SeriesPost")]
    public class SeriesPost
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string TeamIDwinner { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string LgIDwinner { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string Round { get; set; }

        [StringLength(3)]
        public string TeamIDloser { get; set; }

        [StringLength(2)]
        public string LgIDloser { get; set; }

        public short? Wins { get; set; }

        public short? Losses { get; set; }

        public short? Ties { get; set; }

        public virtual Team Teams { get; set; }

        //public virtual Team Teams1 { get; set; }
    }
}
