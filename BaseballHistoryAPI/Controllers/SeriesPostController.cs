using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class SeriesPostController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool SeriesPostExists(string teamIDwinner, string lgIDwinner, int yearID, string round)
        {
            return db.SeriesPost.Any(p => p.teamIDwinner == teamIDwinner && p.lgIDwinner == lgIDwinner && p.yearID == yearID && p.round == round);
        }

        [EnableQuery]
        public IQueryable<SeriesPost> Get()
        {
            return db.SeriesPost;
        }

        [EnableQuery]
        [ODataRoute("SeriesPost(teamIDwinner={teamIDwinner},lgIDwinner={lgIDwinner},yearID={yearID},round={round})")]
        public SingleResult<SeriesPost> Get([FromODataUri] string teamIDwinner, [FromODataUri] string lgIDwinner, [FromODataUri] int yearID, [FromODataUri] string round)
        {
            IQueryable<SeriesPost> result = db.SeriesPost.Where(p => p.teamIDwinner == teamIDwinner && p.lgIDwinner == lgIDwinner && p.yearID == yearID && p.round == round);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}