namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeamBattingTotal
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

        public int? G_batting { get; set; }

        public int? AB { get; set; }

        public int? R { get; set; }

        public int? H { get; set; }

        [Column("2B")]
        public int? C2B { get; set; }

        [Column("3B")]
        public int? C3B { get; set; }

        public int? HR { get; set; }

        public int? RBI { get; set; }

        public int? SB { get; set; }

        public int? CS { get; set; }

        public int? BB { get; set; }

        public int? SO { get; set; }

        public int? IBB { get; set; }

        public int? HPB { get; set; }

        public int? SH { get; set; }

        public int? SF { get; set; }

        public int? GIDP { get; set; }
    }
}
