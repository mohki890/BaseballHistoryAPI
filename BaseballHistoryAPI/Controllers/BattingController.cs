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
    public class BattingController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool BattingExists(string playerID, string teamID, string lgID, int yearID, int stint)
        {
            return db.Batting.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.stint == stint);
        }

        [EnableQuery]
        public IQueryable<Batting> Get()
        {
            return db.Batting;
        }
        [EnableQuery]
        public SingleResult<Batting> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] int stint)
        {
            IQueryable<Batting> result = db.Batting.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.stint == stint);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}