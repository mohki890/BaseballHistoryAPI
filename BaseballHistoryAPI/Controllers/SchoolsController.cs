using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class SchoolsController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool SchoolsExists(string schoolID)
        {
            return db.Schools.Any(p => p.schoolID == schoolID);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<School> Get()
        {
            return db.Schools;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Schools(schoolID={schoolID})")]
        public SingleResult<School> Get([FromODataUri] string schoolID)
        {
            IQueryable<School> result = db.Schools.Where(p => p.schoolID == schoolID);
            return SingleResult.Create(result);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Schools(schoolID={schoolID})/CollegePlaying")]
        public IQueryable<CollegePlaying> GetCollegePlaying([FromODataUri] string schoolID)
        {
            return db.Schools.Where(p => p.schoolID == schoolID).SelectMany(p => p.CollegePlaying);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}