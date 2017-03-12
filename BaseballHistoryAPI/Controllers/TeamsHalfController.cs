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
        private bool TeamsHalfExists(string teamID, string lgID, int yearID, string half)
        {
            return db.TeamsHalf.Any(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.Half == half);
        }

        [EnableQuery]
        public IQueryable<TeamsHalf> Get()
        {
            return db.TeamsHalf;
        }
        [EnableQuery]
        public SingleResult<TeamsHalf> Get([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string half)
        {
            IQueryable<TeamsHalf> result = db.TeamsHalf.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.Half == half);
            return SingleResult.Create(result);
        }
  
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}