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
    public class TeamPitchingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamPitchingTotalsExists(int key)
        {
            return db.TeamPitchingTotals.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<TeamPitchingTotal> Get()
        {
            return db.TeamPitchingTotals;
        }
        [EnableQuery]
        public SingleResult<TeamPitchingTotal> Get([FromODataUri] int key)
        {
            IQueryable<TeamPitchingTotal> result = db.TeamPitchingTotals.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}