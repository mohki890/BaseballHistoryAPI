namespace BaseballHistoryAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class School
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School()
        {
            CollegePlaying = new HashSet<CollegePlaying>();
        }

        [Key]
        [StringLength(15)]
        public string SchoolId { get; set; }

        [StringLength(255)]
        public string NameFull { get; set; }

        [StringLength(55)]
        public string City { get; set; }

        [StringLength(55)]
        public string State { get; set; }

        [StringLength(55)]
        public string Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollegePlaying> CollegePlaying { get; set; }
    }
}
