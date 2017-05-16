namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class HomeGame
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string TeamId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string LgId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string Parkkey { get; set; }

        [StringLength(10)]
        public string Spanfirst { get; set; }

        [StringLength(10)]
        public string Spanlast { get; set; }

        public short? Games { get; set; }

        public short? Openings { get; set; }

        public int? Attendance { get; set; }

        public virtual Team Teams { get; set; }
    }
}
