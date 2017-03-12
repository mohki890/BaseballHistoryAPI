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