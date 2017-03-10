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
    public class FieldingController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool FieldingExists(int key)
        {
            return db.Fielding.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Fielding> Get()
        {
            return db.Fielding;
        }
        [EnableQuery]
        public SingleResult<Fielding> Get([FromODataUri] int key)
        {
            IQueryable<Fielding> result = db.Fielding.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}