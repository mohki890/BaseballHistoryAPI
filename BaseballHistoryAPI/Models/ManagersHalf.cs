namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ManagersHalf")]
    public class ManagersHalf
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
        public short Inseason { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Half { get; set; }

        public short? G { get; set; }

        public short? W { get; set; }

        public short? L { get; set; }

        public short? Rank { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
