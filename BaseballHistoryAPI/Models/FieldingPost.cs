namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FieldingPost")]
    public partial class FieldingPost
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string playerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string teamID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string lgID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short yearID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string round { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string POS { get; set; }

        public short? G { get; set; }

        public short? GS { get; set; }

        public short? InnOuts { get; set; }

        public short? PO { get; set; }

        public short? A { get; set; }

        public short? E { get; set; }

        public short? DP { get; set; }

        public short? TP { get; set; }

        public short? PB { get; set; }

        public short? SB { get; set; }

        public short? CS { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
