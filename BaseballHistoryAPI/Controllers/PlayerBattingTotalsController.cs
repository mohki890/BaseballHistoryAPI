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
    public class PlayerBattingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PlayerBattingTotalsExists(int key)
        {
            return db.PlayerBattingTotals.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<PlayerBattingTotal> Get()
        {
            return db.PlayerBattingTotals;
        }
        [EnableQuery]
        public SingleResult<PlayerBattingTotal> Get([FromODataUri] int key)
        {
            IQueryable<PlayerBattingTotal> result = db.PlayerBattingTotals.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}