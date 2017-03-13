namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PlayerFieldingTotal
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string playerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string POS { get; set; }

        public int? G { get; set; }

        public int? GS { get; set; }

        public int? InnOuts { get; set; }

        public int? PO { get; set; }

        public int? A { get; set; }

        public int? E { get; set; }

        public int? DP { get; set; }

        public int? PB { get; set; }

        public int? WP { get; set; }

        public int? SB { get; set; }

        public int? CS { get; set; }

        public double? ZR { get; set; }
    }
}
