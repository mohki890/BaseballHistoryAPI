namespace BaseballHistoryAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TeamFranchise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeamFranchise()
        {
            Teams = new HashSet<Team>();
        }

        [Key]
        [StringLength(3)]
        public string franchID { get; set; }

        [StringLength(50)]
        public string franchName { get; set; }

        [StringLength(2)]
        public string active { get; set; }

        [StringLength(3)]
        public string NAassoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Team> Teams { get; set; }
    }
}
