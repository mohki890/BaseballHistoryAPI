using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PlayerBattingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PlayerBattingTotalsExists(string playerID)
        {
            return db.PlayerBattingTotals.Any(p => p.playerID == playerID);
        }

        [EnableQuery]
        public IQueryable<PlayerBattingTotal> Get()
        {
            return db.PlayerBattingTotals;
        }

        [EnableQuery]
        [ODataRoute("PlayerBattingTotals(playerID={playerID})")]
        public SingleResult<PlayerBattingTotal> Get([FromODataUri] string playerID)
        {
            IQueryable<PlayerBattingTotal> result = db.PlayerBattingTotals.Where(p => p.playerID == playerID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}