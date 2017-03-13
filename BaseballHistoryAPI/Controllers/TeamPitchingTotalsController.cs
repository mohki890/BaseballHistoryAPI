using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamPitchingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamPitchingTotalsExists(string teamID, string lgID, int yearID)
        {
            return db.TeamPitchingTotals.Any(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
        }

        [EnableQuery]
        public IQueryable<TeamPitchingTotal> Get()
        {
            return db.TeamPitchingTotals;
        }

        [EnableQuery]
        [ODataRoute("TeamPitchingTotals(teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<TeamPitchingTotal> Get([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            IQueryable<TeamPitchingTotal> result = db.TeamPitchingTotals.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}