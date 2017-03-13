using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class MasterController : ODataController
    {
        BaseballStatsModel db = new BaseballStatsModel();
        private bool MasterExists(string playerID)
        {
            return db.Master.Any(p => p.playerID == playerID);
        }

        [EnableQuery]
        public IQueryable<Master> Get()
        {
            return db.Master;
        }

        [EnableQuery]
        [ODataRoute("Master(playerID={playerID})")]
        public SingleResult<Master> Get([FromODataUri] string playerID)
        {
            IQueryable<Master> result = db.Master.Where(p => p.playerID == playerID);
            return SingleResult.Create(result);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/Batting")]
        public IQueryable<Batting> GetBatting([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.Batting);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/Pitching")]
        public IQueryable<Pitching> GetPitching([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.Pitching);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/Fielding")]
        public IQueryable<Fielding> GetFielding([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.Fielding);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/AllstarFull")]
        public IQueryable<AllstarFull> GetAllstarFull([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.AllstarFull);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/Appearances")]
        public IQueryable<Appearance> GetAppearances([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.Appearances);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/AwardsManagers")]
        public IQueryable<AwardsManager> GetAwardsManagers([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.AwardsManagers);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/AwardsPlayers")]
        public IQueryable<AwardsPlayer> GetAwardsPlayers([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.AwardsPlayers);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/AwardsShareManagers")]
        public IQueryable<AwardsShareManager> GetAwardsShareManagers([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.AwardsShareManagers);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/AwardsSharePlayers")]
        public IQueryable<AwardsSharePlayer> GetAwardsSharePlayers([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.AwardsSharePlayers);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/BattingPost")]
        public IQueryable<BattingPost> GetBattingPost([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.BattingPost);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/CollegePlaying")]
        public IQueryable<CollegePlaying> GetCollegePlaying([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.CollegePlaying);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/FieldingOF")]
        public IQueryable<FieldingOF> GetFieldingOF([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.FieldingOF);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/FieldingOFsplit")]
        public IQueryable<FieldingOFsplit> GetFieldingOFsplit([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.FieldingOFsplit);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/FieldingPost")]
        public IQueryable<FieldingPost> GetFieldingPost([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.FieldingPost);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/HallOfFame")]
        public IQueryable<HallOfFame> GetHallOfFame([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.HallOfFame);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/Managers")]
        public IQueryable<Manager> GetManagers([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.Managers);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/ManagersHalf")]
        public IQueryable<ManagersHalf> GetManagersHalf([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.ManagersHalf);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/PitchingPost")]
        public IQueryable<PitchingPost> GetPitchingPost([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.PitchingPost);
        }

        [EnableQuery]
        [ODataRoute("Master({playerID})/Salaries")]
        public IQueryable<Salary> GetSalaries([FromODataUri] string playerID)
        {
            return db.Master.Where(p => p.playerID == playerID).SelectMany(p => p.Salaries);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}