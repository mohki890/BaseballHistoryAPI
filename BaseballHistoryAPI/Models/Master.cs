namespace BaseballHistoryAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Master")]
    public class Master
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
            FieldingOf = new HashSet<FieldingOf>();
            FieldingOFsplit = new HashSet<FieldingOFsplit>();
            FieldingPost = new HashSet<FieldingPost>();
            HallOfFame = new HashSet<HallOfFame>();
            Managers = new HashSet<Manager>();
            ManagersHalf = new HashSet<ManagersHalf>();
            Pitching = new HashSet<Pitching>();
            PitchingPost = new HashSet<PitchingPost>();
            Salaries = new HashSet<Salary>();
        }

        [Key]
        [StringLength(9)]
        public string PlayerId { get; set; }

        public short? BirthYear { get; set; }

        public short? BirthMonth { get; set; }

        public short? BirthDay { get; set; }

        [StringLength(255)]
        public string BirthCountry { get; set; }

        [StringLength(255)]
        public string BirthState { get; set; }

        [StringLength(255)]
        public string BirthCity { get; set; }

        public short? DeathYear { get; set; }

        public short? DeathMonth { get; set; }

        public short? DeathDay { get; set; }

        [StringLength(255)]
        public string DeathCountry { get; set; }

        [StringLength(255)]
        public string DeathState { get; set; }

        [StringLength(255)]
        public string DeathCity { get; set; }

        [StringLength(255)]
        public string NameFirst { get; set; }

        [StringLength(255)]
        public string NameLast { get; set; }

        [StringLength(255)]
        public string NameGiven { get; set; }

        public short? Weight { get; set; }

        public short? Height { get; set; }

        [StringLength(255)]
        public string Bats { get; set; }

        [StringLength(255)]
        public string Throws { get; set; }

        [StringLength(255)]
        public string Debut { get; set; }

        [StringLength(255)]
        public string FinalGame { get; set; }

        [StringLength(255)]
        public string RetroId { get; set; }

        [StringLength(255)]
        public string BbrefId { get; set; }

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
        public virtual ICollection<FieldingOf> FieldingOf { get; set; }

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
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
