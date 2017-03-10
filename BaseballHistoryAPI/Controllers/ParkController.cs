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
    public class ParkController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool ProductExists(int key)
        {
            return db.Parks.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Park> Get()
        {
            return db.Parks;
        }
        [EnableQuery]
        public SingleResult<Park> Get([FromODataUri] int key)
        {
            IQueryable<Park> result = db.Parks.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}