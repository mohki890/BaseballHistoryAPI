using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class BattingPostController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool BattingPostExists(string playerId, string teamId, string lgId, int yearId, string round)
        {
            return _db.BattingPost.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<BattingPost> Get()
        {
            return _db.BattingPost;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("BattingPost(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},round={round})")]
        public SingleResult<BattingPost> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string round)
        {
            IQueryable<BattingPost> result = _db.BattingPost.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}