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
    public class TeamsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool TeamsExists(int key)
        {
            return db.Teams.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Teams> Get()
        {
            return db.Teams;
        }
        [EnableQuery]
        public SingleResult<Teams> Get([FromODataUri] int key)
        {
            IQueryable<Teams> result = db.Teams.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}