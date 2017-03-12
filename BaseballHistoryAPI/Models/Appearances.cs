namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appearance
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

        public short? G_all { get; set; }

        public short? GS { get; set; }

        public short? G_batting { get; set; }

        public short? G_defense { get; set; }

        public short? G_p { get; set; }

        public short? G_c { get; set; }

        public short? G_1b { get; set; }

        public short? G_2b { get; set; }

        public short? G_3b { get; set; }

        public short? G_ss { get; set; }

        public short? G_lf { get; set; }

        public short? G_cf { get; set; }

        public short? G_rf { get; set; }

        public short? G_of { get; set; }

        public short? G_dh { get; set; }

        public short? G_ph { get; set; }

        public short? G_pr { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
