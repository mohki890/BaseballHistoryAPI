namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Fielding")]
    public class Fielding
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

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string Pos { get; set; }

        public short? G { get; set; }

        public short? Gs { get; set; }

        public short? InnOuts { get; set; }

        public short? Po { get; set; }

        public short? A { get; set; }

        public short? E { get; set; }

        public short? Dp { get; set; }

        public short? Pb { get; set; }

        public short? Wp { get; set; }

        public short? Sb { get; set; }

        public short? Cs { get; set; }

        public double? Zr { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
