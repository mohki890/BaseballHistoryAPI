namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class HomeGame
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
        [StringLength(6)]
        public string parkkey { get; set; }

        [StringLength(10)]
        public string spanfirst { get; set; }

        [StringLength(10)]
        public string spanlast { get; set; }

        public short? games { get; set; }

        public short? openings { get; set; }

        public int? attendance { get; set; }

        public virtual Team Teams { get; set; }
    }
}
