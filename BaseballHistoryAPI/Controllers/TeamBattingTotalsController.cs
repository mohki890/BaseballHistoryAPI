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
    public class TeamBattingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamBattingTotalsExists(int key)
        {
            return db.TeamBattingTotals.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<TeamBattingTotal> Get()
        {
            return db.TeamBattingTotals;
        }
        [EnableQuery]
        public SingleResult<TeamBattingTotal> Get([FromODataUri] int key)
        {
            IQueryable<TeamBattingTotal> result = db.TeamBattingTotals.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}