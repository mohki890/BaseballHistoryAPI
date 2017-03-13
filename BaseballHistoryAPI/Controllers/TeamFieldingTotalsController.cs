using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamFieldingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamFieldingTotalsExists(string teamID, string lgID, int yearID)
        {
            return db.TeamFieldingTotals.Any(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
        }

        [EnableQuery]
        public IQueryable<TeamFieldingTotal> Get()
        {
            return db.TeamFieldingTotals;
        }

        [EnableQuery]
        [ODataRoute("TeamFieldingTotals(teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<TeamFieldingTotal> Get([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            IQueryable<TeamFieldingTotal> result = db.TeamFieldingTotals.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}