using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class FieldingOfController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool FieldingOfExists(string playerId, int yearId, int stint)
        {
            return _db.FieldingOf.Any(p => p.PlayerId == playerId && p.YearId == yearId && p.Stint == stint);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<FieldingOf> Get()
        {
            return _db.FieldingOf;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("FieldingOF(playerID={playerID},yearID={yearID},stint={stint})")]
        public SingleResult<FieldingOf> Get([FromODataUri] string playerId, int yearId, int stint)
        {
            IQueryable<FieldingOf> result = _db.FieldingOf.Where(p => p.PlayerId == playerId && p.YearId == yearId && p.Stint == stint);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}