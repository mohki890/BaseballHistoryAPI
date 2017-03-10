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
    public class HallOfFameController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool HallOfFameExists(int key)
        {
            return db.HallOfFame.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<HallOfFame> Get()
        {
            return db.HallOfFame;
        }
        [EnableQuery]
        public SingleResult<HallOfFame> Get([FromODataUri] int key)
        {
            IQueryable<HallOfFame> result = db.HallOfFame.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}