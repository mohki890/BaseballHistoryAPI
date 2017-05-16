using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PitchingController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool PitchingExists(string playerId, string teamId, string lgId, int yearId, int stint)
        {
            return _db.Pitching.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Pitching> Get()
        {
            return _db.Pitching;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Pitching(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},stint={stint})")]
        public SingleResult<Pitching> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] int stint)
        {
            IQueryable<Pitching> result = _db.Pitching.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}