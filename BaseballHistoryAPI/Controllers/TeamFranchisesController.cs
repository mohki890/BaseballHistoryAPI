using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;

namespace BaseballHistoryAPI.Controllers
{
    public class TeamFranchisesController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamFranchisesExists(string key)
        {
            return db.TeamFranchises.Any(p => p.franchID == key);
        }

        [EnableQuery]
        public IQueryable<TeamFranchise> Get()
        {
            return db.TeamFranchises;
        }
        [EnableQuery]
        public SingleResult<TeamFranchise> Get([FromODataUri] string key)
        {
            IQueryable<TeamFranchise> result = db.TeamFranchises.Where(p => p.franchID == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}