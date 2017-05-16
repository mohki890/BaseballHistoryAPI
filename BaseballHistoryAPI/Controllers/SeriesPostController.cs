using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class SeriesPostController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool SeriesPostExists(string teamIDwinner, string lgIDwinner, int yearId, string round)
        {
            return _db.SeriesPost.Any(p => p.TeamIDwinner == teamIDwinner && p.LgIDwinner == lgIDwinner && p.YearId == yearId && p.Round == round);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<SeriesPost> Get()
        {
            return _db.SeriesPost;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("SeriesPost(teamIDwinner={teamIDwinner},lgIDwinner={lgIDwinner},yearID={yearID},round={round})")]
        public SingleResult<SeriesPost> Get([FromODataUri] string teamIDwinner, [FromODataUri] string lgIDwinner, [FromODataUri] int yearId, [FromODataUri] string round)
        {
            IQueryable<SeriesPost> result = _db.SeriesPost.Where(p => p.TeamIDwinner == teamIDwinner && p.LgIDwinner == lgIDwinner && p.YearId == yearId && p.Round == round);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}