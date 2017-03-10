namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FieldingOF")]
    public partial class FieldingOF
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string playerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short yearID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short stint { get; set; }

        public short? Glf { get; set; }

        public short? Gcf { get; set; }

        public short? Grf { get; set; }

        public virtual Master Master { get; set; }
    }
}
