namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeamsFranchises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeamsFranchises()
        {
            Teams = new HashSet<Teams>();
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
        public virtual ICollection<Teams> Teams { get; set; }
    }
}
