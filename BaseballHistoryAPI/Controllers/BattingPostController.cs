using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class BattingPostController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool BattingPostExists(string playerID, string teamID, string lgID, int yearID, string round)
        {
            return db.BattingPost.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.round == round);
        }

        [EnableQuery]
        public IQueryable<BattingPost> Get()
        {
            return db.BattingPost;
        }

        [EnableQuery]
        [ODataRoute("BattingPost(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},round={round})")]
        public SingleResult<BattingPost> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string round)
        {
            IQueryable<BattingPost> result = db.BattingPost.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.round == round);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}