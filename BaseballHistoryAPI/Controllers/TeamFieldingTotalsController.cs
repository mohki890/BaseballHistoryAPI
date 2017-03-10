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
    public class TeamFieldingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamFieldingTotalsExists(int key)
        {
            return db.TeamFieldingTotals.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<TeamFieldingTotal> Get()
        {
            return db.TeamFieldingTotals;
        }
        [EnableQuery]
        public SingleResult<TeamFieldingTotal> Get([FromODataUri] int key)
        {
            IQueryable<TeamFieldingTotal> result = db.TeamFieldingTotals.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}