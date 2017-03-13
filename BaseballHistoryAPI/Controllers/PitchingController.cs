using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PitchingController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PitchingExists(string playerID, string teamID, string lgID, int yearID, int stint)
        {
            return db.Pitching.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.stint == stint);
        }

        [EnableQuery]
        public IQueryable<Pitching> Get()
        {
            return db.Pitching;
        }

        [EnableQuery]
        [ODataRoute("Pitching(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},stint={stint})")]
        public SingleResult<Pitching> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] int stint)
        {
            IQueryable<Pitching> result = db.Pitching.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.stint == stint);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}