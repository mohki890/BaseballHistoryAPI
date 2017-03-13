namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PlayerBattingTotal
    {
        [Key]
        [StringLength(9)]
        public string playerID { get; set; }

        public int? G { get; set; }

        public int? G_batting { get; set; }

        public int? AB { get; set; }

        public int? R { get; set; }

        public int? H { get; set; }

        [Column("2B")]
        public int? H2B { get; set; }

        [Column("3B")]
        public int? H3B { get; set; }

        public int? HR { get; set; }

        public int? RBI { get; set; }

        public int? SB { get; set; }

        public int? CS { get; set; }

        public int? BB { get; set; }

        public int? SO { get; set; }

        public int? IBB { get; set; }

        public int? HPB { get; set; }

        public int? SH { get; set; }

        public int? SF { get; set; }

        public int? GIDP { get; set; }
    }
}
