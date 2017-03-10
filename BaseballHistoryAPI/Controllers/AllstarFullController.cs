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
    public class AllstarFullController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();

        private bool AllstarFullExists(int key)
        {
            return db.AllstarFull.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<AllstarFull> Get()
        {
            return db.AllstarFull;
        }
        [EnableQuery]
        public SingleResult<AllstarFull> Get([FromODataUri] int key)
        {
            IQueryable<AllstarFull> result = db.AllstarFull.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}