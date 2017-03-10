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
    public class AwardsSharePlayerController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool AwardsSharePlayersExists(int key)
        {
            return db.AwardsSharePlayers.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<AwardsSharePlayer> Get()
        {
            return db.AwardsSharePlayers;
        }
        [EnableQuery]
        public SingleResult<AwardsSharePlayer> Get([FromODataUri] int key)
        {
            IQueryable<AwardsSharePlayer> result = db.AwardsSharePlayers.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}