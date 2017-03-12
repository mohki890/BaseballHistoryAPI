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
    public class FieldingPostController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool FieldingPostExists(string playerID, string teamID, string lgID, int yearID, string round, string POS)
        {
            return db.FieldingPost.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.round == round && p.POS == POS);
        }

        [EnableQuery]
        public IQueryable<FieldingPost> Get()
        {
            return db.FieldingPost;
        }
        [EnableQuery]
        public SingleResult<FieldingPost> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string round, [FromODataUri] string POS)
        {
            IQueryable<FieldingPost> result = db.FieldingPost.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.round == round && p.POS == POS);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}