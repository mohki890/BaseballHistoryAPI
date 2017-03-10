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
    public class SeriesPostController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool SeriesPostExists(int key)
        {
            return db.SeriesPost.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<SeriesPost> Get()
        {
            return db.SeriesPost;
        }
        [EnableQuery]
        public SingleResult<SeriesPost> Get([FromODataUri] int key)
        {
            IQueryable<SeriesPost> result = db.SeriesPost.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}