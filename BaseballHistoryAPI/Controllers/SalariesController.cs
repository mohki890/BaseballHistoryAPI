using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class SalariesController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool SalariesExists(string playerID, string teamID, string lgID, int yearID)
        {
            return db.Salaries.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Salary> Get()
        {
            return db.Salaries;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Salaries(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID})")]
        public SingleResult<Salary> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID)
        {
            IQueryable<Salary> result = db.Salaries.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}