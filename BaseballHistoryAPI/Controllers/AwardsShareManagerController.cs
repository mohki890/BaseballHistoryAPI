using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;

namespace BaseballHistoryAPI.Controllers
{
    public class AwardsShareManagerController : ODataController
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