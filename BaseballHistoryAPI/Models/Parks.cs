 namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Park
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Park()
        {
            HomeGames = new HashSet<HomeGame>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(255)]
        public string parkalias { get; set; }

        [StringLength(6)]
        public string parkkey { get; set; }

        [StringLength(255)]
        public string parkname { get; set; }

        [StringLength(255)]
        public string city { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HomeGame> HomeGames { get; set; }
    }
}
