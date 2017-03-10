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
    public class AppearancesController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AppearancesExists(int key)
        {
            return db.Appearances.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Appearance> Get()
        {
            return db.Appearances;
        }
        [EnableQuery]
        public SingleResult<Appearance> Get([FromODataUri] int key)
        {
            IQueryable<Appearance> result = db.Appearances.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}