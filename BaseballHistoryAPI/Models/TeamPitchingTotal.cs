namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TeamPitchingTotal
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

        public int? W { get; set; }

        public int? L { get; set; }

        public int? G { get; set; }

        public int? Gs { get; set; }

        public int? Cg { get; set; }

        public int? Sho { get; set; }

        public int? Sv { get; set; }

        public int? Pouts { get; set; }

        public int? H { get; set; }

        public int? Er { get; set; }

        public int? Hr { get; set; }

        public int? Bb { get; set; }

        public int? So { get; set; }

        public double? BaOpp { get; set; }

        public int? Ibb { get; set; }

        public int? Wp { get; set; }

        public int? Hbp { get; set; }

        public int? Bk { get; set; }

        public int? Bfp { get; set; }

        public int? Gf { get; set; }

        public int? R { get; set; }

        public int? Sh { get; set; }

        public int? Sf { get; set; }

        public int? Gidp { get; set; }
    }
}
