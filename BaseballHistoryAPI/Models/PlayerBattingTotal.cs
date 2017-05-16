namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PlayerBattingTotal
    {
        [Key]
        [StringLength(9)]
        public string PlayerId { get; set; }

        public int? G { get; set; }

        public int? GBatting { get; set; }

        public int? Ab { get; set; }

        public int? R { get; set; }

        public int? H { get; set; }

        [Column("2B")]
        public int? H2B { get; set; }

        [Column("3B")]
        public int? H3B { get; set; }

        public int? Hr { get; set; }

        public int? Rbi { get; set; }

        public int? Sb { get; set; }

        public int? Cs { get; set; }

        public int? Bb { get; set; }

        public int? So { get; set; }

        public int? Ibb { get; set; }

        public int? Hpb { get; set; }

        public int? Sh { get; set; }

        public int? Sf { get; set; }

        public int? Gidp { get; set; }
    }
}
