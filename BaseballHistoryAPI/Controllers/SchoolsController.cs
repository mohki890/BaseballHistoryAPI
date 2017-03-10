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
    public class SchoolsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool SchoolsExists(int key)
        {
            return db.Schools.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Schools> Get()
        {
            return db.Schools;
        }
        [EnableQuery]
        public SingleResult<Schools> Get([FromODataUri] int key)
        {
            IQueryable<Schools> result = db.Schools.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}