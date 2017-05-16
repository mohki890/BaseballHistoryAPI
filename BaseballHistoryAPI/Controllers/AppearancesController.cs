using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AppearancesController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool AppearancesExists(string playerId, string teamId, string lgId, int yearId)
        {
            return _db.Appearances.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Appearance> Get()
        {
            return _db.Appearances;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Appearances(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<Appearance> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            IQueryable<Appearance> result = _db.Appearances.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}