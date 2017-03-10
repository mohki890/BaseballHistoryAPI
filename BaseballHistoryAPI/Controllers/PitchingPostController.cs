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
        private bool PitchingPostExists(int key)
        {
            return db.PitchingPost.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<PitchingPost> Get()
        {
            return db.PitchingPost;
        }
        [EnableQuery]
        public SingleResult<PitchingPost> Get([FromODataUri] int key)
        {
            IQueryable<PitchingPost> result = db.PitchingPost.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}