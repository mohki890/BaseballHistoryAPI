using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class SalariesController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool SalariesExists(string playerId, string teamId, string lgId, int yearId)
        {
            return _db.Salaries.Any(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Salary> Get()
        {
            return _db.Salaries;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Salaries(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<Salary> Get([FromODataUri] string playerId, [FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId)
        {
            IQueryable<Salary> result = _db.Salaries.Where(p => p.PlayerId == playerId && p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}