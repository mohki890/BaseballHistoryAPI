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
    public class TeamsHalfController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamsHalfExists(int key)
        {
            return db.TeamsHalf.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<TeamsHalf> Get()
        {
            return db.TeamsHalf;
        }
        [EnableQuery]
        public SingleResult<TeamsHalf> Get([FromODataUri] int key)
        {
            IQueryable<TeamsHalf> result = db.TeamsHalf.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }
  
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}