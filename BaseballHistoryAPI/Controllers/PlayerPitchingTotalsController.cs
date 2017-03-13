using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PlayerPitchingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PlayerPitchingTotalsExists(string playerID)
        {
            return db.PlayerPitchingTotals.Any(p => p.playerID == playerID);
        }

        [EnableQuery]
        public IQueryable<PlayerPitchingTotal> Get()
        {
            return db.PlayerPitchingTotals;
        }

        [EnableQuery]
        [ODataRoute("PlayerPitchingTotals(playerID={playerID})")]
        public SingleResult<PlayerPitchingTotal> Get([FromODataUri] string playerID)
        {
            IQueryable<PlayerPitchingTotal> result = db.PlayerPitchingTotals.Where(p => p.playerID == playerID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}