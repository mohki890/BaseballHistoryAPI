namespace BaseballHistoryAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CollegePlaying")]
    public partial class CollegePlaying
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
        [StringLength(15)]
        public string schoolID { get; set; }

        public virtual Master Master { get; set; }

        public virtual School Schools { get; set; }
    }
}
