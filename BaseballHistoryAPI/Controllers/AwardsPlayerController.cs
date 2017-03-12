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
    public class AwardsPlayerController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AwardsPlayersExists(string playerID, string lgID, int yearID, string awardID)
        {
            return db.AwardsPlayers.Any(p => p.playerID == playerID && p.lgID == lgID && p.yearID == yearID && p.awardID == awardID);
        }

        [EnableQuery]
        public IQueryable<AwardsPlayer> Get()
        {
            return db.AwardsPlayers;
        }
        [EnableQuery]
        public SingleResult<AwardsPlayer> Get([FromODataUri] string playerID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string awardID)
        {
            IQueryable<AwardsPlayer> result = db.AwardsPlayers.Where(p => p.playerID == playerID && p.lgID == lgID && p.yearID == yearID && p.awardID == awardID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}