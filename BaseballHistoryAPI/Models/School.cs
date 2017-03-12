namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class School
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School()
        {
            CollegePlaying = new HashSet<CollegePlaying>();
        }

        [Key]
        [StringLength(15)]
        public string schoolID { get; set; }

        [StringLength(255)]
        public string name_full { get; set; }

        [StringLength(55)]
        public string city { get; set; }

        [StringLength(55)]
        public string state { get; set; }

        [StringLength(55)]
        public string country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollegePlaying> CollegePlaying { get; set; }
    }
}
