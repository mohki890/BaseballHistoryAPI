using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class ParksController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool ProductExists(int ID)
        {
            return db.Parks.Any(p => p.ID == ID);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Park> Get()
        {
            return db.Parks;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Parks(ID={ID})")]
        public SingleResult<Park> Get([FromODataUri] int ID)
        {
            IQueryable<Park> result = db.Parks.Where(p => p.ID == ID);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}