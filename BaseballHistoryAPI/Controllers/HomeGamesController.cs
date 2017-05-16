using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class HomeGamesController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool HomeGamesExists(string teamId, string lgId, int yearId, string parkkey)
        {
            return _db.HomeGames.Any(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Parkkey == parkkey);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<HomeGame> Get()
        {
            return _db.HomeGames;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("HomeGames(teamID={teamID},lgID={lgID},yearID={yearID},parkkey={parkkey})")]
        public SingleResult<HomeGame> Get([FromODataUri] string teamId, [FromODataUri] string lgId, [FromODataUri] int yearId, [FromODataUri] string parkkey)
        {
            IQueryable<HomeGame> result = _db.HomeGames.Where(p => p.TeamId == teamId && p.LgId == lgId && p.YearId == yearId && p.Parkkey == parkkey);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}