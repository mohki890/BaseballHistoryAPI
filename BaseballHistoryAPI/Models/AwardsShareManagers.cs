namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AwardsShareManager
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
        [StringLength(25)]
        public string awardID { get; set; }

        public short? pointsWon { get; set; }

        public short? pointsMax { get; set; }

        public short? votesFirst { get; set; }

        public virtual Master Master { get; set; }
    }
}
