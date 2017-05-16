namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HallOfFame")]
    public class HallOfFame
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string PlayerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Yearid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string VotedBy { get; set; }

        public short? Ballots { get; set; }

        public short? Needed { get; set; }

        public short? Votes { get; set; }

        [StringLength(1)]
        public string Inducted { get; set; }

        [StringLength(20)]
        public string Category { get; set; }

        [StringLength(25)]
        public string NeededNote { get; set; }

        public virtual Master Master { get; set; }
    }
}
