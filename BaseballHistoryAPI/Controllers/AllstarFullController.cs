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
    public class AllstarFullController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();

        private bool AllstarFullExists(string playerID, string teamID, string lgID, int yearID, string gameID)
        {
            return db.AllstarFull.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.gameID == gameID);
        }

        [EnableQuery]
        public IQueryable<AllstarFull> Get()
        {
            return db.AllstarFull;
        }
        [EnableQuery]
        public SingleResult<AllstarFull> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string gameID)
        {
            IQueryable<AllstarFull> result = db.AllstarFull.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.gameID == gameID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}