namespace BaseballHistoryAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class TeamFranchise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeamFranchise()
        {
            Teams = new HashSet<Team>();
        }

        [Key]
        [StringLength(3)]
        public string FranchId { get; set; }

        [StringLength(50)]
        public string FranchName { get; set; }

        [StringLength(2)]
        public string Active { get; set; }

        [StringLength(3)]
        public string NAassoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Team> Teams { get; set; }
    }
}
