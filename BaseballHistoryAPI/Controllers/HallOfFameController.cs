using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class HallOfFameController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool HallOfFameExists(string playerID, int yearID, string votedBy)
        {
            return db.HallOfFame.Any(p => p.playerID == playerID && p.yearid == yearID && p.votedBy == votedBy);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<HallOfFame> Get()
        {
            return db.HallOfFame;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("HallOfFame(playerID={playerID},yearid={yearid},votedBy={votedBy})")]
        public SingleResult<HallOfFame> Get([FromODataUri] string playerID, [FromODataUri] int yearID, [FromODataUri] string votedBy)
        {
            IQueryable<HallOfFame> result = db.HallOfFame.Where(p => p.playerID == playerID && p.yearid == yearID && p.votedBy == votedBy);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}