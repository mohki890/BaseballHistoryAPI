using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class CollegePlayingController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool CollegePlayingExists(string playerId, int yearId, string schoolId)
        {
            return _db.CollegePlaying.Any(p => p.PlayerId == playerId && p.YearId == yearId && p.SchoolId == schoolId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<CollegePlaying> Get()
        {
            return _db.CollegePlaying;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("CollegePlaying(playerID={playerID},yearID={yearID},schoolID={schoolID})")]
        public SingleResult<CollegePlaying> Get([FromODataUri] string playerId, [FromODataUri] int yearId, [FromODataUri] string schoolId)
        {
            IQueryable<CollegePlaying> result = _db.CollegePlaying.Where(p => p.PlayerId == playerId && p.YearId == yearId && p.SchoolId == schoolId);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}