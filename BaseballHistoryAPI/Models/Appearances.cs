namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Appearance
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string PlayerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TeamId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string LgId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearId { get; set; }

        public short? GAll { get; set; }

        public short? Gs { get; set; }

        public short? GBatting { get; set; }

        public short? GDefense { get; set; }

        public short? GP { get; set; }

        public short? GC { get; set; }

        public short? G_1B { get; set; }

        public short? G_2B { get; set; }

        public short? G_3B { get; set; }

        public short? GSs { get; set; }

        public short? GLf { get; set; }

        public short? GCf { get; set; }

        public short? GRf { get; set; }

        public short? GOf { get; set; }

        public short? GDh { get; set; }

        public short? GPh { get; set; }

        public short? GPr { get; set; }

        public virtual Master Master { get; set; }

        public virtual Team Teams { get; set; }
    }
}
