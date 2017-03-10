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
        private bool TeamsFranchisesExists(int key)
        {
            return db.TeamsFranchises.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<TeamsFranchises> Get()
        {
            return db.TeamsFranchises;
        }
        [EnableQuery]
        public SingleResult<TeamsFranchises> Get([FromODataUri] int key)
        {
            IQueryable<TeamsFranchises> result = db.TeamsFranchises.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}