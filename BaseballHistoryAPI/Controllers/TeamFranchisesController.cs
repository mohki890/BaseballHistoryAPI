using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamFranchisesController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool TeamFranchisesExists(string franchId)
        {
            return _db.TeamFranchises.Any(p => p.FranchId == franchId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<TeamFranchise> Get()
        {
            return _db.TeamFranchises;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("TeamFranchises({franchID})")]
        public SingleResult<TeamFranchise> Get([FromODataUri] string franchId)
        {
            IQueryable<TeamFranchise> result = _db.TeamFranchises.Where(p => p.FranchId == franchId);
            return SingleResult.Create(result);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("TeamFranchises({franchID})/Teams")]
        public IQueryable<Team> GetTeams([FromODataUri] string franchId)
        {
            return _db.TeamFranchises.Where(p => p.FranchId == franchId).SelectMany(p => p.Teams);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}