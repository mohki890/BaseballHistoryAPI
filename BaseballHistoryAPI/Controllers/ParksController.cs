using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class ParksController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool ProductExists(int id)
        {
            return _db.Parks.Any(p => p.Id == id);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Park> Get()
        {
            return _db.Parks;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Parks(ID={ID})")]
        public SingleResult<Park> Get([FromODataUri] int id)
        {
            IQueryable<Park> result = _db.Parks.Where(p => p.Id == id);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}