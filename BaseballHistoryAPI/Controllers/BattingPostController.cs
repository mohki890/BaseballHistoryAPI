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
    public class BattingPostController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool BattingPostExists(int key)
        {
            return db.BattingPost.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<BattingPost> Get()
        {
            return db.BattingPost;
        }
        [EnableQuery]
        public SingleResult<BattingPost> Get([FromODataUri] int key)
        {
            IQueryable<BattingPost> result = db.BattingPost.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}