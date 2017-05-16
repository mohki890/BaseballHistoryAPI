namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PlayerFieldingTotal
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string PlayerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string Pos { get; set; }

        public int? G { get; set; }

        public int? Gs { get; set; }

        public int? InnOuts { get; set; }

        public int? Po { get; set; }

        public int? A { get; set; }

        public int? E { get; set; }

        public int? Dp { get; set; }

        public int? Pb { get; set; }

        public int? Wp { get; set; }

        public int? Sb { get; set; }

        public int? Cs { get; set; }

        public double? Zr { get; set; }
    }
}
