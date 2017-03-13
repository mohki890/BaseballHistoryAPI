using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamsExists(string teamID, string lgID, int yearID)
        {
            return db.Teams.Any(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
        }

        [EnableQuery]
        public IQueryable<Team> Get()
        {
            return db.Teams;
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<Team> Get([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            IQueryable<Team> result = db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
            return SingleResult.Create(result);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Batting")]
        public IQueryable<Batting> GetBatting([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.Batting);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Pitching")]
        public IQueryable<Pitching> GetPitching([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.Pitching);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Fielding")]
        public IQueryable<Fielding> GetFielding([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.Fielding);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/AllstarFull")]
        public IQueryable<AllstarFull> GetAllstarFull([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.AllstarFull);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Appearances")]
        public IQueryable<Appearance> GetAppearances([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.Appearances);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/BattingPost")]
        public IQueryable<BattingPost> GetBattingPost([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.BattingPost);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/FieldingOFsplit")]
        public IQueryable<FieldingOFsplit> GetFieldingOFsplit([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.FieldingOFsplit);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/FieldingPost")]
        public IQueryable<FieldingPost> GetFieldingPost([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.FieldingPost);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Managers")]
        public IQueryable<Manager> GetManagers([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.Managers);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/ManagersHalf")]
        public IQueryable<ManagersHalf> GetManagersHalf([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.ManagersHalf);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/PitchingPost")]
        public IQueryable<PitchingPost> GetPitchingPost([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.PitchingPost);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/Salaries")]
        public IQueryable<Salary> GetSalaries([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.Salaries);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/ManagersHalf")]
        public IQueryable<HomeGame> GetHomeGames([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.HomeGames);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/PitchingPost")]
        public IQueryable<SeriesPost> GetSeriesPost([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.SeriesPost);
        }

        [EnableQuery]
        [ODataRoute("Teams(teamID={teamID},lgID={lgID},yearID={yearID})/TeamsHalf")]
        public IQueryable<TeamsHalf> GetTeamsHalf([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            return db.Teams.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID).SelectMany(p => p.TeamsHalf);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}