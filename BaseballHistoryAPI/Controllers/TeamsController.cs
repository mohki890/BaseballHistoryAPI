using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamsController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool TeamsExists(string teamId, string lgId, int yearId)
        {
            return _db.Teams.Any(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Team> Get()
        {
            return _db.Teams;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<Team> Get([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            IQueryable<Team> result = _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return SingleResult.Create(result);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Batting")]
        public IQueryable<Batting> GetBatting([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Batting);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Pitching")]
        public IQueryable<Pitching> GetPitching([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Pitching);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Fielding")]
        public IQueryable<Fielding> GetFielding([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Fielding);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/AllstarFull")]
        public IQueryable<AllstarFull> GetAllstarFull([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.AllstarFull);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Appearances")]
        public IQueryable<Appearance> GetAppearances([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Appearances);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/BattingPost")]
        public IQueryable<BattingPost> GetBattingPost([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.BattingPost);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/FieldingOFsplit")]
        public IQueryable<FieldingOFsplit> GetFieldingOFsplit([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.FieldingOFsplit);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/FieldingPost")]
        public IQueryable<FieldingPost> GetFieldingPost([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.FieldingPost);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Managers")]
        public IQueryable<Manager> GetManagers([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Managers);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/ManagersHalf")]
        public IQueryable<ManagersHalf> GetManagersHalf([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.ManagersHalf);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/PitchingPost")]
        public IQueryable<PitchingPost> GetPitchingPost([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.PitchingPost);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Salaries")]
        public IQueryable<Salary> GetSalaries([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.Salaries);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/ManagersHalf")]
        public IQueryable<HomeGame> GetHomeGames([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.HomeGames);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/PitchingPost")]
        public IQueryable<SeriesPost> GetSeriesPost([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.SeriesPost);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/TeamsHalf")]
        public IQueryable<TeamsHalf> GetTeamsHalf([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            return _db.Teams.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId).SelectMany(p => p.TeamsHalf);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}