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
        private bool FieldingOFsplitExists(int key)
        {
            return db.FieldingOFsplit.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<FieldingOFsplit> Get()
        {
            return db.FieldingOFsplit;
        }
        [EnableQuery]
        public SingleResult<FieldingOFsplit> Get([FromODataUri] int key)
        {
            IQueryable<FieldingOFsplit> result = db.FieldingOFsplit.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}