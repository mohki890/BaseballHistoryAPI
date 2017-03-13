using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AwardsManagersController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AwardsManagersExists(string playerID, string lgID, int yearID, string awardID)
        {
            return db.AwardsManagers.Any(p => p.playerID == playerID && p.lgID == lgID && p.yearID == yearID && p.awardID == awardID);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<AwardsManager> Get()
        {
            return db.AwardsManagers;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("AwardsManagers(playerID={playerID},lgID={lgID},yearID={yearID},awardID={awardID})")]
        public SingleResult<AwardsManager> Get([FromODataUri] string playerID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string awardID)
        {
            IQueryable<AwardsManager> result = db.AwardsManagers.Where(p => p.playerID == playerID && p.lgID == lgID && p.yearID == yearID && p.awardID == awardID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}