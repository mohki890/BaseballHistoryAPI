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
    public class CollegePlayingController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool CollegePlayingExists(string playerID, int yearID, string schoolID)
        {
            return db.CollegePlaying.Any(p => p.playerID == playerID && p.yearID == yearID && p.schoolID == schoolID);
        }

        [EnableQuery]
        public IQueryable<CollegePlaying> Get()
        {
            return db.CollegePlaying;
        }
        [EnableQuery]
        public SingleResult<CollegePlaying> Get([FromODataUri] string playerID, [FromODataUri] int yearID, [FromODataUri] string schoolID)
        {
            IQueryable<CollegePlaying> result = db.CollegePlaying.Where(p => p.playerID == playerID && p.yearID == yearID && p.schoolID == schoolID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}