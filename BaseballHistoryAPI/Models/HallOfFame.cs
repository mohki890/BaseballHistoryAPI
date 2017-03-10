namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HallOfFame")]
    public partial class HallOfFame
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string playerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short yearid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string votedBy { get; set; }

        public short? ballots { get; set; }

        public short? needed { get; set; }

        public short? votes { get; set; }

        [StringLength(1)]
        public string inducted { get; set; }

        [StringLength(20)]
        public string category { get; set; }

        [StringLength(25)]
        public string needed_note { get; set; }

        public virtual Master Master { get; set; }
    }
}
