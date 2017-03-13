using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AwardsShareManagersController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AwardsShareManagersExists(string playerID, string lgID, int yearID, string awardID)
        {
            return db.AwardsShareManagers.Any(p => p.playerID == playerID && p.lgID == lgID && p.yearID == yearID && p.awardID == awardID);
        }

        [EnableQuery]
        public IQueryable<AwardsShareManager> Get()
        {
            return db.AwardsShareManagers;
        }

        [EnableQuery]
        [ODataRoute("AwardsShareManagers(playerID={playerID},lgID={lgID},yearID={yearID},awardID={awardID})")]
        public SingleResult<AwardsShareManager> Get([FromODataUri] string playerID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string awardID)
        {
            IQueryable<AwardsShareManager> result = db.AwardsShareManagers.Where(p => p.playerID == playerID && p.lgID == lgID && p.yearID == yearID && p.awardID == awardID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}