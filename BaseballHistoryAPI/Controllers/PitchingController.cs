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
    public class PitchingController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PitchingExists(int key)
        {
            return db.Pitching.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Pitching> Get()
        {
            return db.Pitching;
        }
        [EnableQuery]
        public SingleResult<Pitching> Get([FromODataUri] int key)
        {
            IQueryable<Pitching> result = db.Pitching.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}