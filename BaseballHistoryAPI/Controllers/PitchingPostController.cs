using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class PitchingPostController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool PitchingPostExists(string playerId, string teamId, string lgId, int yearId, string round)
        {
            return _db.PitchingPost.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<PitchingPost> Get()
        {
            return _db.PitchingPost;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("PitchingPost(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},round={round})")]
        public SingleResult<PitchingPost> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string round)
        {
            IQueryable<PitchingPost> result = _db.PitchingPost.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}