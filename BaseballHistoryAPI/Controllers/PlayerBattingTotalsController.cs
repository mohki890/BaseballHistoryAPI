using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PlayerBattingTotalsController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool PlayerBattingTotalsExists(string playerId)
        {
            return _db.PlayerBattingTotals.Any(p => p.PlayerId == playerId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<PlayerBattingTotal> Get()
        {
            return _db.PlayerBattingTotals;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("PlayerBattingTotals(playerID={playerID})")]
        public SingleResult<PlayerBattingTotal> Get([FromODataUri] string playerId)
        {
            IQueryable<PlayerBattingTotal> result = _db.PlayerBattingTotals.Where(p => p.PlayerId == playerId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}