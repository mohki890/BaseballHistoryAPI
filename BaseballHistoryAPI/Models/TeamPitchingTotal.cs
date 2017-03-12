namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeamPitchingTotal
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

        public int? W { get; set; }

        public int? L { get; set; }

        public int? G { get; set; }

        public int? GS { get; set; }

        public int? CG { get; set; }

        public int? SHO { get; set; }

        public int? SV { get; set; }

        public int? IPouts { get; set; }

        public int? H { get; set; }

        public int? ER { get; set; }

        public int? HR { get; set; }

        public int? BB { get; set; }

        public int? SO { get; set; }

        public double? BAOpp { get; set; }

        public int? IBB { get; set; }

        public int? WP { get; set; }

        public int? HBP { get; set; }

        public int? BK { get; set; }

        public int? BFP { get; set; }

        public int? GF { get; set; }

        public int? R { get; set; }

        public int? SH { get; set; }

        public int? SF { get; set; }

        public int? GIDP { get; set; }
    }
}
