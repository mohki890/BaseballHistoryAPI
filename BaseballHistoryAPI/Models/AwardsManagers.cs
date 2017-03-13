namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AwardsManager
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string playerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string lgID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short yearID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(75)]
        public string awardID { get; set; }

        [StringLength(1)]
        public string tie { get; set; }

        [StringLength(100)]
        public string notes { get; set; }

        public virtual Master Master { get; set; }
    }
}
