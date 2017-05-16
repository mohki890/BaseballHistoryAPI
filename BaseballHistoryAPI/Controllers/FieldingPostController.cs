using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class FieldingPostController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool FieldingPostExists(string playerId, string teamId, string lgId, int yearId, string round, string pos)
        {
            return _db.FieldingPost.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round && p.Pos == pos);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<FieldingPost> Get()
        {
            return _db.FieldingPost;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("FieldingPost(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},round={round},POS={POS})")]
        public SingleResult<FieldingPost> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string round, [FromODataUri] string pos)
        {
            IQueryable<FieldingPost> result = _db.FieldingPost.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Round == round && p.Pos == pos);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}