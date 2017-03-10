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
        private bool FieldingOFExists(int key)
        {
            return db.FieldingOF.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<FieldingOF> Get()
        {
            return db.FieldingOF;
        }
        [EnableQuery]
        public SingleResult<FieldingOF> Get([FromODataUri] int key)
        {
            IQueryable<FieldingOF> result = db.FieldingOF.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}