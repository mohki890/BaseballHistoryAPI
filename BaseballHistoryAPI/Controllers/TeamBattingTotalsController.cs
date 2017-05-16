using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamBattingTotalsController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool TeamBattingTotalsExists(string teamId, string lgId, int yearId)
        {
            return _db.TeamBattingTotals.Any(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<TeamBattingTotal> Get()
        {
            return _db.TeamBattingTotals;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("TeamBattingTotals(teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<TeamBattingTotal> Get([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            IQueryable<TeamBattingTotal> result = _db.TeamBattingTotals.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}