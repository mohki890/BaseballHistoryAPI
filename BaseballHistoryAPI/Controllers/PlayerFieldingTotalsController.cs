using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PlayerFieldingTotalsController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool PlayerFieldingTotalsExists(string playerId, string pos)
        {
            return _db.PlayerFieldingTotals.Any(p => p.PlayerId == playerId && p.Pos == pos);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<PlayerFieldingTotal> Get()
        {
            return _db.PlayerFieldingTotals;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("PlayerFieldingTotals(playerID={playerID},POS={POS})")]
        public SingleResult<PlayerFieldingTotal> Get([FromODataUri] string playerId, [FromODataUri] string pos)
        {
            IQueryable<PlayerFieldingTotal> result = _db.PlayerFieldingTotals.Where(p => p.PlayerId == playerId && p.Pos == pos);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}