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
    public class ManagerController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool ManagersExists(string playerID, string teamID, string lgID, int yearID, int inseason)
        {
            return db.Managers.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.inseason == inseason);
        }

        [EnableQuery]
        public IQueryable<Manager> Get()
        {
            return db.Managers;
        }
        [EnableQuery]
        public SingleResult<Manager> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] int inseason)
        {
            IQueryable<Manager> result = db.Managers.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.inseason == inseason);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}