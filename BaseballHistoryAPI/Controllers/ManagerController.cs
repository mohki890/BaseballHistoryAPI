using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class ManagerController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool ManagersExists(string playerId, string teamId, string lgId, int yearId, int inseason)
        {
            return _db.Managers.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Inseason == inseason);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Manager> Get()
        {
            return _db.Managers;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Managers(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},inseason={inseason})")]
        public SingleResult<Manager> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] int inseason)
        {
            IQueryable<Manager> result = _db.Managers.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Inseason == inseason);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}