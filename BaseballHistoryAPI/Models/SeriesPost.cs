namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SeriesPost")]
    public partial class SeriesPost
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string teamIDwinner { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string lgIDwinner { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short yearID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string round { get; set; }

        [StringLength(3)]
        public string teamIDloser { get; set; }

        [StringLength(2)]
        public string lgIDloser { get; set; }

        public short? wins { get; set; }

        public short? losses { get; set; }

        public short? ties { get; set; }

        public virtual Team Teams { get; set; }

        //public virtual Team Teams1 { get; set; }
    }
}
