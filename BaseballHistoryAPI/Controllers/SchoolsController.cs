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
        private bool SchoolsExists(string key)
        {
            return db.Schools.Any(p => p.schoolID == key);
        }

        [EnableQuery]
        public IQueryable<School> Get()
        {
            return db.Schools;
        }
        [EnableQuery]
        public SingleResult<School> Get([FromODataUri] string key)
        {
            IQueryable<School> result = db.Schools.Where(p => p.schoolID == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}