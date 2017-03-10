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
    public class PlayerFieldingTotalsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PlayerFieldingTotalsExists(int key)
        {
            return db.PlayerFieldingTotals.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<PlayerFieldingTotal> Get()
        {
            return db.PlayerFieldingTotals;
        }
        [EnableQuery]
        public SingleResult<PlayerFieldingTotal> Get([FromODataUri] int key)
        {
            IQueryable<PlayerFieldingTotal> result = db.PlayerFieldingTotals.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}