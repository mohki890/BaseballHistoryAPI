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
    public class MasterController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool MasterExists(string key)
        {
            return db.Master.Any(p => p.playerID == key);
        }

        [EnableQuery]
        public IQueryable<Master> Get()
        {
            return db.Master;
        }
        [EnableQuery]
        public SingleResult<Master> Get([FromODataUri] string key)
        {
            IQueryable<Master> result = db.Master.Where(p => p.playerID == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}