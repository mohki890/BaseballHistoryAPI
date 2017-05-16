using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamsHalfController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool TeamsHalfExists(string teamId, string lgId, int yearId, string half)
        {
            return _db.TeamsHalf.Any(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Half == half);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<TeamsHalf> Get()
        {
            return _db.TeamsHalf;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("TeamsHalf(teamID={teamID},lgID={lgID},yearID={yearID},Half={Half})")]
        public SingleResult<TeamsHalf> Get([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string half)
        {
            IQueryable<TeamsHalf> result = _db.TeamsHalf.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Half == half);
            return SingleResult.Create(result);
        }
  
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}