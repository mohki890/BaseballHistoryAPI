using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class FieldingOFController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool FieldingOFExists(string playerID, int yearID, int stint)
        {
            return db.FieldingOF.Any(p => p.playerID == playerID && p.yearID == yearID && p.stint == stint);
        }

        [EnableQuery]
        public IQueryable<FieldingOF> Get()
        {
            return db.FieldingOF;
        }

        [EnableQuery]
        [ODataRoute("FieldingOF(playerID={playerID},yearID={yearID},stint={stint})")]
        public SingleResult<FieldingOF> Get([FromODataUri] string playerID, int yearID, int stint)
        {
            IQueryable<FieldingOF> result = db.FieldingOF.Where(p => p.playerID == playerID && p.yearID == yearID && p.stint == stint);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}