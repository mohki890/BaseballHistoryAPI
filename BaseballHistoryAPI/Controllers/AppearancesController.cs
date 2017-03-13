using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class AppearancesController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AppearancesExists(string playerID, string teamID, string lgID, int yearID)
        {
            return db.Appearances.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Appearance> Get()
        {
            return db.Appearances;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Appearances(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<Appearance> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            IQueryable<Appearance> result = db.Appearances.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}