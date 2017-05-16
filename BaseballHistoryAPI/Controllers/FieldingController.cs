using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class FieldingController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool FieldingExists(string playerId, string teamId, string lgId, int yearId, int stint, string pos)
        {
            return _db.Fielding.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint && p.Pos == pos);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Fielding> Get()
        {
            return _db.Fielding;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Fielding(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},stint={stint},POS={POS})")]
        public SingleResult<Fielding> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] int stint, [FromODataUri] string pos)
        {
            IQueryable<Fielding> result = _db.Fielding.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint && p.Pos == pos);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}