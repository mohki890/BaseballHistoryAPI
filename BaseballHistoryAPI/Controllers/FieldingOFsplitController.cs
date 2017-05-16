using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class FieldingOFsplitController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool FieldingOFsplitExists(string playerId, string teamId, string lgId, int yearId, int stint, string pos)
        {
            return _db.FieldingOFsplit.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint && p.Pos == pos);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<FieldingOFsplit> Get()
        {
            return _db.FieldingOFsplit;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("FieldingOFsplit(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},stint={stint},POS={POS})")]
        public SingleResult<FieldingOFsplit> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] int stint, [FromODataUri] string pos)
        {
            IQueryable<FieldingOFsplit> result = _db.FieldingOFsplit.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Stint == stint && p.Pos == pos);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}