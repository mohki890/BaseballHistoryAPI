namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class TeamFieldingTotal
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string teamID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string lgID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short yearID { get; set; }

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
