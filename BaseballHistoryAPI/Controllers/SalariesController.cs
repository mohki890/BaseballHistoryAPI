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
    public class SalariesController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool SalariesExists(int key)
        {
            return db.Salaries.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Salaries> Get()
        {
            return db.Salaries;
        }
        [EnableQuery]
        public SingleResult<Salaries> Get([FromODataUri] int key)
        {
            IQueryable<Salaries> result = db.Salaries.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}