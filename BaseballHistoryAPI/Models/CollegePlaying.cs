namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CollegePlaying")]
    public class CollegePlaying
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
        [StringLength(15)]
        public string SchoolId { get; set; }

        public virtual Master Master { get; set; }

        public virtual School Schools { get; set; }
    }
}
