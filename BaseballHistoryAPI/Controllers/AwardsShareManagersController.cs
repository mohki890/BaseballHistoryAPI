using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AwardsShareManagersController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool AwardsShareManagersExists(string playerId, string lgId, int yearId, string awardId)
        {
            return _db.AwardsShareManagers.Any(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<AwardsShareManager> Get()
        {
            return _db.AwardsShareManagers;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("AwardsShareManagers(playerID={playerID},lgID={lgID},yearID={yearID},awardID={awardID})")]
        public SingleResult<AwardsShareManager> Get([FromODataUri] string playerId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string awardId)
        {
            IQueryable<AwardsShareManager> result = _db.AwardsShareManagers.Where(p => p.PlayerId == playerId && p.LgId == lgId && p.YearId == yearId && p.AwardId == awardId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}