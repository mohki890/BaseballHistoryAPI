using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamBattingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamBattingTotalsExists(string teamID, string lgID, int yearID)
        {
            return db.TeamBattingTotals.Any(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
        }

        [EnableQuery]
        public IQueryable<TeamBattingTotal> Get()
        {
            return db.TeamBattingTotals;
        }

        [EnableQuery]
        [ODataRoute("TeamBattingTotals(teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<TeamBattingTotal> Get([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            IQueryable<TeamBattingTotal> result = db.TeamBattingTotals.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}