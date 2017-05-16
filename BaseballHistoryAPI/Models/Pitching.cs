namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Pitching")]
    public class Pitching
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Stint { get; set; }

        public short? W { get; set; }

        public short? L { get; set; }

        public short? G { get; set; }

        public short? Gs { get; set; }

        public short? Cg { get; set; }

        public short? Sho { get; set; }

        public short? Sv { get; set; }

        public int? Pouts { get; set; }

        public short? H { get; set; }

        public short? Er { get; set; }

        public short? Hr { get; set; }

        public short? Bb { get; set; }

        public short? So { get; set; }

        public double? BaOpp { get; set; }

        public double? Era { get; set; }

        public short? Ibb { get; set; }

        public short? Wp { get; set; }

        public short? Hbp { get; set; }

        public short? Bk { get; set; }

        public short? Bfp { get; set; }

        public short? Gf { get; set; }

        public short? R { get; set; }

        public short? Sh { get; set; }

        public short? Sf { get; set; }

        public short? Gidp { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
