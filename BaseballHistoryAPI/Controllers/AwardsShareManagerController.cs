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
    public class AwardsShareManagerController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AwardsShareManagersExists(int key)
        {
            return db.AwardsShareManagers.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<AwardsShareManager> Get()
        {
            return db.AwardsShareManagers;
        }
        [EnableQuery]
        public SingleResult<AwardsShareManager> Get([FromODataUri] int key)
        {
            IQueryable<AwardsShareManager> result = db.AwardsShareManagers.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}