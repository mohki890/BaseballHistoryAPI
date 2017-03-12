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
        private bool ProductExists(int ID)
        {
            return db.Parks.Any(p => p.ID == ID);
        }

        [EnableQuery]
        public IQueryable<Park> Get()
        {
            return db.Parks;
        }
        [EnableQuery]
        public SingleResult<Park> Get([FromODataUri] int ID)
        {
            IQueryable<Park> result = db.Parks.Where(p => p.ID == ID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}