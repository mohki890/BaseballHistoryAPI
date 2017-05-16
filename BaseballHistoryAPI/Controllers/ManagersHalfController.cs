using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class ManagersHalfController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool ManagersHalfExists(string playerId, string teamId, string lgId, int yearId, int inseason, int half)
        {
            return _db.ManagersHalf.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Inseason == inseason && p.Half == half);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<ManagersHalf> Get()
        {
            return _db.ManagersHalf;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("ManagersHalf(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},inseason={inseason},half={half})")]
        public SingleResult<ManagersHalf> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] int inseason, [FromODataUri] int half)
        {
            IQueryable<ManagersHalf> result = _db.ManagersHalf.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Inseason == inseason && p.Half == half);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}