namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Master")]
    public partial class Master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Master()
        {
            AllstarFull = new HashSet<AllstarFull>();
            Appearances = new HashSet<Appearance>();
            AwardsManagers = new HashSet<AwardsManager>();
            AwardsPlayers = new HashSet<AwardsPlayer>();
            AwardsShareManagers = new HashSet<AwardsShareManager>();
            AwardsSharePlayers = new HashSet<AwardsSharePlayer>();
            Batting = new HashSet<Batting>();
            BattingPost = new HashSet<BattingPost>();
            CollegePlaying = new HashSet<CollegePlaying>();
            Fielding = new HashSet<Fielding>();
            FieldingOF = new HashSet<FieldingOF>();
            FieldingOFsplit = new HashSet<FieldingOFsplit>();
            FieldingPost = new HashSet<FieldingPost>();
            HallOfFame = new HashSet<HallOfFame>();
            Managers = new HashSet<Manager>();
            ManagersHalf = new HashSet<ManagersHalf>();
            Pitching = new HashSet<Pitching>();
            PitchingPost = new HashSet<PitchingPost>();
            Salaries = new HashSet<Salaries>();
        }

        [Key]
        [StringLength(9)]
        public string playerID { get; set; }

        public short? birthYear { get; set; }

        public short? birthMonth { get; set; }

        public short? birthDay { get; set; }

        [StringLength(255)]
        public string birthCountry { get; set; }

        [StringLength(255)]
        public string birthState { get; set; }

        [StringLength(255)]
        public string birthCity { get; set; }

        public short? deathYear { get; set; }

        public short? deathMonth { get; set; }

        public short? deathDay { get; set; }

        [StringLength(255)]
        public string deathCountry { get; set; }

        [StringLength(255)]
        public string deathState { get; set; }

        [StringLength(255)]
        public string deathCity { get; set; }

        [StringLength(255)]
        public string nameFirst { get; set; }

        [StringLength(255)]
        public string nameLast { get; set; }

        [StringLength(255)]
        public string nameGiven { get; set; }

        public short? weight { get; set; }

        public short? height { get; set; }

        [StringLength(255)]
        public string bats { get; set; }

        [StringLength(255)]
        public string throws { get; set; }

        [StringLength(255)]
        public string debut { get; set; }

        [StringLength(255)]
        public string finalGame { get; set; }

        [StringLength(255)]
        public string retroID { get; set; }

        [StringLength(255)]
        public string bbrefID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllstarFull> AllstarFull { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appearance> Appearances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AwardsManager> AwardsManagers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AwardsPlayer> AwardsPlayers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AwardsShareManager> AwardsShareManagers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AwardsSharePlayer> AwardsSharePlayers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Batting> Batting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BattingPost> BattingPost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollegePlaying> CollegePlaying { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fielding> Fielding { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldingOF> FieldingOF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldingOFsplit> FieldingOFsplit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldingPost> FieldingPost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HallOfFame> HallOfFame { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manager> Managers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagersHalf> ManagersHalf { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pitching> Pitching { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PitchingPost> PitchingPost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salaries> Salaries { get; set; }
    }
}
