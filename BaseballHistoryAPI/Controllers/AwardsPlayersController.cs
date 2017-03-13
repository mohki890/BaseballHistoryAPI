using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AwardsPlayersController : ODataController
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
        [ODataRoute("AwardsPlayers(playerID={playerID},lgID={lgID},yearID={yearID},awardID={awardID})")]
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