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
    public class TeamsFranchisesController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamsFranchisesExists(string key)
        {
            return db.TeamsFranchises.Any(p => p.franchID == key);
        }

        [EnableQuery]
        public IQueryable<TeamsFranchise> Get()
        {
            return db.TeamsFranchises;
        }
        [EnableQuery]
        public SingleResult<TeamsFranchise> Get([FromODataUri] string key)
        {
            IQueryable<TeamsFranchise> result = db.TeamsFranchises.Where(p => p.franchID == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}