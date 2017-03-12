namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pitching")]
    public partial class Pitching
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
        public short stint { get; set; }

        public short? W { get; set; }

        public short? L { get; set; }

        public short? G { get; set; }

        public short? GS { get; set; }

        public short? CG { get; set; }

        public short? SHO { get; set; }

        public short? SV { get; set; }

        public int? IPouts { get; set; }

        public short? H { get; set; }

        public short? ER { get; set; }

        public short? HR { get; set; }

        public short? BB { get; set; }

        public short? SO { get; set; }

        public double? BAOpp { get; set; }

        public double? ERA { get; set; }

        public short? IBB { get; set; }

        public short? WP { get; set; }

        public short? HBP { get; set; }

        public short? BK { get; set; }

        public short? BFP { get; set; }

        public short? GF { get; set; }

        public short? R { get; set; }

        public short? SH { get; set; }

        public short? SF { get; set; }

        public short? GIDP { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
