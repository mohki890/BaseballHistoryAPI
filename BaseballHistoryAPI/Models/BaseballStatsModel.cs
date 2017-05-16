namespace BaseballHistoryAPI.Models
{
    using System.Data.Entity;

    public class BaseballStatsModel : DbContext
    {
        public BaseballStatsModel()
            : base("name=BaseballHistoryModel")
        {
        }

        public virtual DbSet<AllstarFull> AllstarFull { get; set; }
        public virtual DbSet<Appearance> Appearances { get; set; }
        public virtual DbSet<AwardsManager> AwardsManagers { get; set; }
        public virtual DbSet<AwardsPlayer> AwardsPlayers { get; set; }
        public virtual DbSet<AwardsShareManager> AwardsShareManagers { get; set; }
        public virtual DbSet<AwardsSharePlayer> AwardsSharePlayers { get; set; }
        public virtual DbSet<Batting> Batting { get; set; }
        public virtual DbSet<BattingPost> BattingPost { get; set; }
        public virtual DbSet<CollegePlaying> CollegePlaying { get; set; }
        public virtual DbSet<Fielding> Fielding { get; set; }
        public virtual DbSet<FieldingOf> FieldingOf { get; set; }
        public virtual DbSet<FieldingOFsplit> FieldingOFsplit { get; set; }
        public virtual DbSet<FieldingPost> FieldingPost { get; set; }
        public virtual DbSet<HallOfFame> HallOfFame { get; set; }
        public virtual DbSet<HomeGame> HomeGames { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<ManagersHalf> ManagersHalf { get; set; }
        public virtual DbSet<Master> Master { get; set; }
        public virtual DbSet<Park> Parks { get; set; }
        public virtual DbSet<Pitching> Pitching { get; set; }
        public virtual DbSet<PitchingPost> PitchingPost { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<SeriesPost> SeriesPost { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamFranchise> TeamFranchises { get; set; }
        public virtual DbSet<TeamsHalf> TeamsHalf { get; set; }
        public virtual DbSet<PlayerBattingTotal> PlayerBattingTotals { get; set; }
        public virtual DbSet<PlayerFieldingTotal> PlayerFieldingTotals { get; set; }
        public virtual DbSet<PlayerPitchingTotal> PlayerPitchingTotals { get; set; }
        public virtual DbSet<TeamBattingTotal> TeamBattingTotals { get; set; }
        public virtual DbSet<TeamFieldingTotal> TeamFieldingTotals { get; set; }
        public virtual DbSet<TeamPitchingTotal> TeamPitchingTotals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Master>()
                .HasMany(e => e.AllstarFull)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.Appearances)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.AwardsManagers)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.AwardsPlayers)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.AwardsShareManagers)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.AwardsSharePlayers)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.Batting)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.BattingPost)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.CollegePlaying)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.Fielding)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.FieldingOf)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.FieldingOFsplit)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.FieldingPost)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.HallOfFame)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.Managers)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.ManagersHalf)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.Pitching)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.PitchingPost)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Master>()
                .HasMany(e => e.Salaries)
                .WithRequired(e => e.Master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<School>()
                .HasMany(e => e.CollegePlaying)
                .WithRequired(e => e.Schools)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.AllstarFull)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Appearances)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Batting)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.BattingPost)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Fielding)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.FieldingOFsplit)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.FieldingPost)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.HomeGames)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Managers)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.ManagersHalf)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Pitching)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.PitchingPost)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Salaries)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.SeriesPost)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamIDwinner = e.TeamIDwinner, lgIDwinner = e.LgIDwinner, yearID = e.YearId })
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Team>()
            //    .HasMany(e => e.SeriesPost1)
            //    .WithOptional(e => e.Teams1)
            //    .HasForeignKey(e => new { e.teamIDloser, e.lgIDloser, e.yearID });

            modelBuilder.Entity<Team>()
                .HasMany(e => e.TeamsHalf)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => new { teamID = e.TeamId, lgID = e.LgId, yearID = e.YearId })
                .WillCascadeOnDelete(false);
        }
    }
}
