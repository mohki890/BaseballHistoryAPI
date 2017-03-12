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
    public class PitchingPostController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool PitchingPostExists(string playerID, string teamID, string lgID, int yearID, string round)
        {
            return db.PitchingPost.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.round == round);
        }

        [EnableQuery]
        public IQueryable<PitchingPost> Get()
        {
            return db.PitchingPost;
        }
        [EnableQuery]
        public SingleResult<PitchingPost> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] string round)
        {
            IQueryable<PitchingPost> result = db.PitchingPost.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.round == round);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}