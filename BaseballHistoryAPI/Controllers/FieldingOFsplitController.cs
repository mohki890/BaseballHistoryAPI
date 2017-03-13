using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class FieldingOFsplitController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool FieldingOFsplitExists(string playerID, string teamID, string lgID, int yearID, int stint, string POS)
        {
            return db.FieldingOFsplit.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.stint == stint && p.POS == POS);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<FieldingOFsplit> Get()
        {
            return db.FieldingOFsplit;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("FieldingOFsplit(playerID={playerID},teamID={teamID},lgID={lgID},yearID={yearID},stint={stint},POS={POS})")]
        public SingleResult<FieldingOFsplit> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] int stint, [FromODataUri] string POS)
        {
            IQueryable<FieldingOFsplit> result = db.FieldingOFsplit.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.stint == stint && p.POS == POS);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}