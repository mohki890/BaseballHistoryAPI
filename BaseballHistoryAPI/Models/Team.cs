namespace BaseballHistoryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            AllstarFull = new HashSet<AllstarFull>();
            Appearances = new HashSet<Appearance>();
            Batting = new HashSet<Batting>();
            BattingPost = new HashSet<BattingPost>();
            Fielding = new HashSet<Fielding>();
            FieldingOFsplit = new HashSet<FieldingOFsplit>();
            FieldingPost = new HashSet<FieldingPost>();
            HomeGames = new HashSet<HomeGame>();
            Managers = new HashSet<Manager>();
            ManagersHalf = new HashSet<ManagersHalf>();
            Pitching = new HashSet<Pitching>();
            PitchingPost = new HashSet<PitchingPost>();
            Salaries = new HashSet<Salary>();
            SeriesPost = new HashSet<SeriesPost>();
            //SeriesPost1 = new HashSet<SeriesPost>();
            TeamsHalf = new HashSet<TeamsHalf>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string teamID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string lgID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short yearID { get; set; }

        [StringLength(3)]
        public string franchID { get; set; }

        [StringLength(1)]
        public string divID { get; set; }

        public short? Rank { get; set; }

        public short? G { get; set; }

        public short? Ghome { get; set; }

        public short? W { get; set; }

        public short? L { get; set; }

        [StringLength(1)]
        public string DivWin { get; set; }

        [StringLength(1)]
        public string WCWin { get; set; }

        [StringLength(1)]
        public string LgWin { get; set; }

        [StringLength(1)]
        public string WSWin { get; set; }

        public short? R { get; set; }

        public short? AB { get; set; }

        public short? H { get; set; }

        [Column("2B")]
        public short? C2B { get; set; }

        [Column("3B")]
        public short? C3B { get; set; }

        public short? HR { get; set; }

        public short? BB { get; set; }

        public short? SO { get; set; }

        public short? SB { get; set; }

        public short? CS { get; set; }

        public short? HBP { get; set; }

        public short? SF { get; set; }

        public short? RA { get; set; }

        public short? ER { get; set; }

        public double? ERA { get; set; }

        public short? CG { get; set; }

        public short? SHO { get; set; }

        public short? SV { get; set; }

        public int? IPouts { get; set; }

        public short? HA { get; set; }

        public short? HRA { get; set; }

        public short? BBA { get; set; }

        public short? SOA { get; set; }

        public int? E { get; set; }

        public int? DP { get; set; }

        public double? FP { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(255)]
        public string park { get; set; }

        public int? attendance { get; set; }

        public int? BPF { get; set; }

        public int? PPF { get; set; }

        [StringLength(3)]
        public string teamIDBR { get; set; }

        [StringLength(3)]
        public string teamIDlahman45 { get; set; }

        [StringLength(3)]
        public string teamIDretro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllstarFull> AllstarFull { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appearance> Appearances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Batting> Batting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BattingPost> BattingPost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fielding> Fielding { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldingOFsplit> FieldingOFsplit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldingPost> FieldingPost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HomeGame> HomeGames { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeriesPost> SeriesPost { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SeriesPost> SeriesPost1 { get; set; }

        public virtual TeamFranchise TeamFranchises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamsHalf> TeamsHalf { get; set; }
    }
}
