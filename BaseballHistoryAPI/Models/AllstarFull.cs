namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AllstarFull")]
    public partial class AllstarFull
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
        [StringLength(12)]
        public string gameID { get; set; }

        public short? startingPos { get; set; }

        public short gameNum { get; set; }

        public short? GP { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
