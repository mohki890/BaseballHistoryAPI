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
    public class FieldingOFsplitController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool FieldingOFsplitExists(string playerID, string teamID, string lgID, int yearID, int stint, string POS)
        {
            return db.FieldingOFsplit.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.stint == stint && p.POS == POS);
        }

        [EnableQuery]
        public IQueryable<FieldingOFsplit> Get()
        {
            return db.FieldingOFsplit;
        }
        [EnableQuery]
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