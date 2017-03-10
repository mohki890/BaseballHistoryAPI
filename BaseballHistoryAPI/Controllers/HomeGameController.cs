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
    public class HomeGameController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool HomeGamesExists(int key)
        {
            return db.HomeGames.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<HomeGame> Get()
        {
            return db.HomeGames;
        }
        [EnableQuery]
        public SingleResult<HomeGame> Get([FromODataUri] int key)
        {
            IQueryable<HomeGame> result = db.HomeGames.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}