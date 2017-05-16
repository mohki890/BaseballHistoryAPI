using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AllstarFullController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();

        private bool AllstarFullExists(string playerId, string teamId, string lgId, int yearId, string gameId)
        {
            return _db.AllstarFull.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.GameId == gameId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<AllstarFull> Get()
        {
            return _db.AllstarFull;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("AllstarFull(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},gameID={gameID})")]
        public SingleResult<AllstarFull> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string gameId)
        {
            IQueryable<AllstarFull> result = _db.AllstarFull.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.GameId == gameId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}