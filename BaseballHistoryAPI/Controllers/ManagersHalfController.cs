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
    public class ManagersHalfController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool ManagersHalfExists(int key)
        {
            return db.ManagersHalf.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<ManagersHalf> Get()
        {
            return db.ManagersHalf;
        }
        [EnableQuery]
        public SingleResult<ManagersHalf> Get([FromODataUri] int key)
        {
            IQueryable<ManagersHalf> result = db.ManagersHalf.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}