namespace BaseballHistoryAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Team
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
            TeamsHalf = new HashSet<TeamsHalf>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string TeamId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string LgId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearId { get; set; }

        [StringLength(3)]
        public string FranchId { get; set; }

        [StringLength(1)]
        public string DivId { get; set; }

        public short? Rank { get; set; }

        public short? G { get; set; }

        public short? Ghome { get; set; }

        public short? W { get; set; }

        public short? L { get; set; }

        [StringLength(1)]
        public string DivWin { get; set; }

        [StringLength(1)]
        public string WcWin { get; set; }

        [StringLength(1)]
        public string LgWin { get; set; }

        [StringLength(1)]
        public string WsWin { get; set; }

        public short? R { get; set; }

        public short? Ab { get; set; }

        public short? H { get; set; }

        [Column("2B")]
        public short? H2B { get; set; }

        [Column("3B")]
        public short? H3B { get; set; }

        public short? Hr { get; set; }

        public short? Bb { get; set; }

        public short? So { get; set; }

        public short? Sb { get; set; }

        public short? Cs { get; set; }

        public short? Hbp { get; set; }

        public short? Sf { get; set; }

        public short? Ra { get; set; }

        public short? Er { get; set; }

        public double? Era { get; set; }

        public short? Cg { get; set; }

        public short? Sho { get; set; }

        public short? Sv { get; set; }

        public int? Pouts { get; set; }

        public short? Ha { get; set; }

        public short? Hra { get; set; }

        public short? Bba { get; set; }

        public short? Soa { get; set; }

        public int? E { get; set; }

        public int? Dp { get; set; }

        public double? Fp { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Park { get; set; }

        public int? Attendance { get; set; }

        public int? Bpf { get; set; }

        public int? Ppf { get; set; }

        [StringLength(3)]
        public string TeamIdbr { get; set; }

        [StringLength(3)]
        public string TeamIDlahman45 { get; set; }

        [StringLength(3)]
        public string TeamIDretro { get; set; }

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
