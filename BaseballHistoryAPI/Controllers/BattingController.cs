using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class BattingController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool BattingExists(string playerId, string teamId, string lgId, int yearId, int stint)
        {
            return _db.Batting.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Batting> Get()
        {
            return _db.Batting;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Batting(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},stint={stint})")]
        public SingleResult<Batting> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] int stint)
        {
            IQueryable<Batting> result = _db.Batting.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}