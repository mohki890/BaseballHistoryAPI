using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class SchoolsController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool SchoolsExists(string schoolId)
        {
            return _db.Schools.Any(p => p.SchoolId == schoolId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<School> Get()
        {
            return _db.Schools;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Schools(schoolID={schoolID})")]
        public SingleResult<School> Get([FromODataUri] string schoolId)
        {
            IQueryable<School> result = _db.Schools.Where(p => p.SchoolId == schoolId);
            return SingleResult.Create(result);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Schools(schoolID={schoolID})/CollegePlaying")]
        public IQueryable<CollegePlaying> GetCollegePlaying([FromODataUri] string schoolId)
        {
            return _db.Schools.Where(p => p.SchoolId == schoolId).SelectMany(p => p.CollegePlaying);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}