namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamsHalf")]
    public partial class TeamsHalf
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

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string Half { get; set; }

        [StringLength(1)]
        public string divID { get; set; }

        [StringLength(1)]
        public string DivWin { get; set; }

        public short? Rank { get; set; }

        public short? G { get; set; }

        public short? W { get; set; }

        public short? L { get; set; }

        public virtual Team Teams { get; set; }
    }
}
