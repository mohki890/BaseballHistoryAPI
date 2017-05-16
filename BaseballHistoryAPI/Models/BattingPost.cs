namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BattingPost")]
    public class BattingPost
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string PlayerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TeamId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string LgId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string Round { get; set; }

        public short? G { get; set; }

        public short? Ab { get; set; }

        public short? R { get; set; }

        public short? H { get; set; }

        [Column("2B")]
        public short? H2B { get; set; }

        [Column("3B")]
        public short? H3B { get; set; }

        public short? Hr { get; set; }

        public short? Rbi { get; set; }

        public short? Sb { get; set; }

        public short? Cs { get; set; }

        public short? Bb { get; set; }

        public short? So { get; set; }

        public short? Ibb { get; set; }

        public short? Hbp { get; set; }

        public short? Sh { get; set; }

        public short? Sf { get; set; }

        public short? Gidp { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
