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
    public class BattingController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool BattingExists(int key)
        {
            return db.Batting.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Batting> Get()
        {
            return db.Batting;
        }
        [EnableQuery]
        public SingleResult<Batting> Get([FromODataUri] int key)
        {
            IQueryable<Batting> result = db.Batting.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}