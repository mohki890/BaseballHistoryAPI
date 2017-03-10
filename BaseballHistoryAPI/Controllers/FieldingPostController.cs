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
        private bool FieldingPostExists(int key)
        {
            return db.FieldingPost.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<FieldingPost> Get()
        {
            return db.FieldingPost;
        }
        [EnableQuery]
        public SingleResult<FieldingPost> Get([FromODataUri] int key)
        {
            IQueryable<FieldingPost> result = db.FieldingPost.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}