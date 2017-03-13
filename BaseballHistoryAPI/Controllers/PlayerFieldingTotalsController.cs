using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PlayerFieldingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PlayerFieldingTotalsExists(string playerID, string POS)
        {
            return db.PlayerFieldingTotals.Any(p => p.playerID == playerID && p.POS == POS);
        }

        [EnableQuery]
        public IQueryable<PlayerFieldingTotal> Get()
        {
            return db.PlayerFieldingTotals;
        }

        [EnableQuery]
        [ODataRoute("PlayerFieldingTotals(playerID={playerID},POS={POS})")]
        public SingleResult<PlayerFieldingTotal> Get([FromODataUri] string playerID, [FromODataUri] string POS)
        {
            IQueryable<PlayerFieldingTotal> result = db.PlayerFieldingTotals.Where(p => p.playerID == playerID && p.POS == POS);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}