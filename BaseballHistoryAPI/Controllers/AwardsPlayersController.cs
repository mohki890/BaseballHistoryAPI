using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AwardsPlayersController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool AwardsPlayersExists(string playerId, string lgId, int yearId, string awardId)
        {
            return _db.AwardsPlayers.Any(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<AwardsPlayer> Get()
        {
            return _db.AwardsPlayers;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("AwardsPlayers(playerID={playerID},lgID={lgID},yearID={yearID},awardID={awardID})")]
        public SingleResult<AwardsPlayer> Get([FromODataUri] string playerId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string awardId)
        {
            IQueryable<AwardsPlayer> result = _db.AwardsPlayers.Where(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}