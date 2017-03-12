﻿using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;

namespace BaseballHistoryAPI.Controllers
{
    public class ManagersHalfController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool ManagersHalfExists(string playerID, string teamID, string lgID, int yearID, int inseason, int half)
        {
            return db.ManagersHalf.Any(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.inseason == inseason && p.half == half);
        }

        [EnableQuery]
        public IQueryable<ManagersHalf> Get()
        {
            return db.ManagersHalf;
        }
        [EnableQuery]
        public SingleResult<ManagersHalf> Get([FromODataUri] string playerID, [FromODataUri] string teamID, [FromODataUri] string lgID, [FromODataUri] int yearID, [FromODataUri] int inseason, [FromODataUri] int half)
        {
            IQueryable<ManagersHalf> result = db.ManagersHalf.Where(p => p.playerID == playerID && p.teamID == teamID && p.lgID == lgID && p.yearID == yearID && p.inseason == inseason && p.half == half);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}