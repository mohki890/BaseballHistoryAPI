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
    public class AwardsPlayerController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AwardsPlayersExists(int key)
        {
            return db.AwardsPlayers.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<AwardsPlayer> Get()
        {
            return db.AwardsPlayers;
        }
        [EnableQuery]
        public SingleResult<AwardsPlayer> Get([FromODataUri] int key)
        {
            IQueryable<AwardsPlayer> result = db.AwardsPlayers.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}