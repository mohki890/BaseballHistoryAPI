using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

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
        [ODataRoute("CollegePlaying(playerID={playerID},yearID={yearID},schoolID={schoolID})")]
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