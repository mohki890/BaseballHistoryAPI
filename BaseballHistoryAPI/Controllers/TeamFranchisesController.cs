using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamFranchisesController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamFranchisesExists(string franchID)
        {
            return db.TeamFranchises.Any(p => p.franchID == franchID);
        }

        [EnableQuery]
        public IQueryable<TeamFranchise> Get()
        {
            return db.TeamFranchises;
        }

        [EnableQuery]
        [ODataRoute("TeamFranchises({franchID})")]
        public SingleResult<TeamFranchise> Get([FromODataUri] string franchID)
        {
            IQueryable<TeamFranchise> result = db.TeamFranchises.Where(p => p.franchID == franchID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}