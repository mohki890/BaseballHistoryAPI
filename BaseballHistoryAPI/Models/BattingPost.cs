namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BattingPost")]
    public partial class BattingPost
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
        [StringLength(10)]
        public string round { get; set; }

        public short? G { get; set; }

        public short? AB { get; set; }

        public short? R { get; set; }

        public short? H { get; set; }

        [Column("2B")]
        public short? H2B { get; set; }

        [Column("3B")]
        public short? H3B { get; set; }

        public short? HR { get; set; }

        public short? RBI { get; set; }

        public short? SB { get; set; }

        public short? CS { get; set; }

        public short? BB { get; set; }

        public short? SO { get; set; }

        public short? IBB { get; set; }

        public short? HBP { get; set; }

        public short? SH { get; set; }

        public short? SF { get; set; }

        public short? GIDP { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
