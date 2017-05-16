using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PlayerPitchingTotalsController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool PlayerPitchingTotalsExists(string playerId)
        {
            return _db.PlayerPitchingTotals.Any(p => p.PlayerId == playerId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<PlayerPitchingTotal> Get()
        {
            return _db.PlayerPitchingTotals;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("PlayerPitchingTotals(playerID={playerID})")]
        public SingleResult<PlayerPitchingTotal> Get([FromODataUri] string playerId)
        {
            IQueryable<PlayerPitchingTotal> result = _db.PlayerPitchingTotals.Where(p => p.PlayerId == playerId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}