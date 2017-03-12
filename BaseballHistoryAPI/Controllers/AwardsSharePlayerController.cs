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
    public class AwardsSharePlayerController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AwardsSharePlayersExists(string playerID, string lgID, int yearID, string awardID)
        {
            return db.AwardsSharePlayers.Any(p => p.playerID == playerID && p.lgID == lgID && p.yearID == yearID && p.awardID == awardID);
        }

        [EnableQuery]
        public IQueryable<AwardsSharePlayer> Get()
        {
            return db.AwardsSharePlayers;
        }
        [EnableQuery]
        public SingleResult<AwardsSharePlayer> Get([FromODataUri] string playerID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string awardID)
        {
            IQueryable<AwardsSharePlayer> result = db.AwardsSharePlayers.Where(p => p.playerID == playerID && p.lgID == lgID && p.yearID == yearID && p.awardID == awardID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}