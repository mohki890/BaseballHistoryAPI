namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Manager
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string playerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string teamID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string lgID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short yearID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short inseason { get; set; }

        public short? G { get; set; }

        public short? W { get; set; }

        public short? L { get; set; }

        public short? rank { get; set; }

        [StringLength(1)]
        public string plyrMgr { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
