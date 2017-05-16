using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AwardsManagersController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool AwardsManagersExists(string playerId, string lgId, int yearId, string awardId)
        {
            return _db.AwardsManagers.Any(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<AwardsManager> Get()
        {
            return _db.AwardsManagers;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("AwardsManagers(playerID={playerID},lgID={lgID},yearID={yearID},awardID={awardID})")]
        public SingleResult<AwardsManager> Get([FromODataUri] string playerId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string awardId)
        {
            IQueryable<AwardsManager> result = _db.AwardsManagers.Where(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}