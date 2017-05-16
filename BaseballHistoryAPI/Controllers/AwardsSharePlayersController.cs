using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AwardsSharePlayersController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool AwardsSharePlayersExists(string playerId, string lgId, int yearId, string awardId)
        {
            return _db.AwardsSharePlayers.Any(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<AwardsSharePlayer> Get()
        {
            return _db.AwardsSharePlayers;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("AwardsSharePlayers(playerID={playerID},lgID={lgID},yearID={yearID},awardID={awardID})")]
        public SingleResult<AwardsSharePlayer> Get([FromODataUri] string playerId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string awardId)
        {
            IQueryable<AwardsSharePlayer> result = _db.AwardsSharePlayers.Where(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}