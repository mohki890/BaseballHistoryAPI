namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Salaries
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

        public double? salary { get; set; }

        public virtual Master Master { get; set; }

        public virtual Teams Teams { get; set; }
    }
}
