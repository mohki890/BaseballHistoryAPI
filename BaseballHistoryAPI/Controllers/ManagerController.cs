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
    public class ManagerController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool ManagersExists(int key)
        {
            return db.Managers.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Manager> Get()
        {
            return db.Managers;
        }
        [EnableQuery]
        public SingleResult<Manager> Get([FromODataUri] int key)
        {
            IQueryable<Manager> result = db.Managers.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}