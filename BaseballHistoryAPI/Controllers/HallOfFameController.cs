using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class HallOfFameController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool HallOfFameExists(string playerId, int yearId, string votedBy)
        {
            return _db.HallOfFame.Any(p => p.PlayerId == playerId && p.Yearid == yearId && p.VotedBy == votedBy);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<HallOfFame> Get()
        {
            return _db.HallOfFame;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("HallOfFame(playerID={playerID},yearid={yearid},votedBy={votedBy})")]
        public SingleResult<HallOfFame> Get([FromODataUri] string playerId, [FromODataUri] int yearId, [FromODataUri] string votedBy)
        {
            IQueryable<HallOfFame> result = _db.HallOfFame.Where(p => p.PlayerId == playerId && p.Yearid == yearId && p.VotedBy == votedBy);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}