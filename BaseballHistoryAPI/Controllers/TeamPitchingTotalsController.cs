using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamPitchingTotalsController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool TeamPitchingTotalsExists(string teamId, string lgId, int yearId)
        {
            return _db.TeamPitchingTotals.Any(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<TeamPitchingTotal> Get()
        {
            return _db.TeamPitchingTotals;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("TeamPitchingTotals(teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<TeamPitchingTotal> Get([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            IQueryable<TeamPitchingTotal> result = _db.TeamPitchingTotals.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}