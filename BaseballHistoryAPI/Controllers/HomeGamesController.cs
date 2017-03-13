using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class HomeGamesController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool HomeGamesExists(string teamID, string lgID, int yearID, string parkkey)
        {
            return db.HomeGames.Any(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.parkkey == parkkey);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<HomeGame> Get()
        {
            return db.HomeGames;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("HomeGames(teamID={teamID},lgID={lgID},yearID={yearID},parkkey={parkkey})")]
        public SingleResult<HomeGame> Get([FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string parkkey)
        {
            IQueryable<HomeGame> result = db.HomeGames.Where(p => p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.parkkey == parkkey);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}