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
    public class PlayerPitchingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PlayerPitchingTotalsExists(string key)
        {
            return db.PlayerPitchingTotals.Any(p => p.playerID == key);
        }

        [EnableQuery]
        public IQueryable<PlayerPitchingTotal> Get()
        {
            return db.PlayerPitchingTotals;
        }
        [EnableQuery]
        public SingleResult<PlayerPitchingTotal> Get([FromODataUri] string key)
        {
            IQueryable<PlayerPitchingTotal> result = db.PlayerPitchingTotals.Where(p => p.playerID == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}