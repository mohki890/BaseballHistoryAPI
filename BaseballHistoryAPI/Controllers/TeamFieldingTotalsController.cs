using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamFieldingTotalsController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool TeamFieldingTotalsExists(string teamId, string lgId, int yearId)
        {
            return _db.TeamFieldingTotals.Any(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<TeamFieldingTotal> Get()
        {
            return _db.TeamFieldingTotals;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("TeamFieldingTotals(teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<TeamFieldingTotal> Get([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            IQueryable<TeamFieldingTotal> result = _db.TeamFieldingTotals.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}