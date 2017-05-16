namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FieldingOF")]
    public class FieldingOf
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string PlayerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Stint { get; set; }

        public short? Glf { get; set; }

        public short? Gcf { get; set; }

        public short? Grf { get; set; }

        public virtual Master Master { get; set; }
    }
}
