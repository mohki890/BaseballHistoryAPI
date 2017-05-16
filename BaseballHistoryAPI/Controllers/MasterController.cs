using System.Linq;
using System.Web.Http;
using System.Web.OData;
using BaseballHistoryAPI.Models;
using System.Web.OData.Routing;

namespace BaseballHistoryAPI.Controllers
{
    public class MasterController : ODataController
    {
        BaseballStatsModel _db = new BaseballStatsModel();
        private bool MasterExists(string playerId)
        {
            return _db.Master.Any(p => p.PlayerId == playerId);
        }

        [EnableQuery(PageSize = 100)]
        public IQueryable<Master> Get()
        {
            return _db.Master;
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master(playerID={playerID})")]
        public SingleResult<Master> Get([FromODataUri] string playerId)
        {
            IQueryable<Master> result = _db.Master.Where(p => p.PlayerId == playerId);
            return SingleResult.Create(result);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/Batting")]
        public IQueryable<Batting> GetBatting([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Batting);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/Pitching")]
        public IQueryable<Pitching> GetPitching([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Pitching);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/Fielding")]
        public IQueryable<Fielding> GetFielding([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Fielding);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/AllstarFull")]
        public IQueryable<AllstarFull> GetAllstarFull([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AllstarFull);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/Appearances")]
        public IQueryable<Appearance> GetAppearances([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Appearances);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/AwardsManagers")]
        public IQueryable<AwardsManager> GetAwardsManagers([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AwardsManagers);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/AwardsPlayers")]
        public IQueryable<AwardsPlayer> GetAwardsPlayers([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AwardsPlayers);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/AwardsShareManagers")]
        public IQueryable<AwardsShareManager> GetAwardsShareManagers([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AwardsShareManagers);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/AwardsSharePlayers")]
        public IQueryable<AwardsSharePlayer> GetAwardsSharePlayers([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.AwardsSharePlayers);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/BattingPost")]
        public IQueryable<BattingPost> GetBattingPost([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.BattingPost);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/CollegePlaying")]
        public IQueryable<CollegePlaying> GetCollegePlaying([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.CollegePlaying);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/FieldingOF")]
        public IQueryable<FieldingOf> GetFieldingOf([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.FieldingOf);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/FieldingOFsplit")]
        public IQueryable<FieldingOFsplit> GetFieldingOFsplit([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.FieldingOFsplit);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/FieldingPost")]
        public IQueryable<FieldingPost> GetFieldingPost([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.FieldingPost);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/HallOfFame")]
        public IQueryable<HallOfFame> GetHallOfFame([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.HallOfFame);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/Managers")]
        public IQueryable<Manager> GetManagers([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Managers);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/ManagersHalf")]
        public IQueryable<ManagersHalf> GetManagersHalf([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.ManagersHalf);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/PitchingPost")]
        public IQueryable<PitchingPost> GetPitchingPost([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.PitchingPost);
        }

        [EnableQuery(PageSize = 100)]
        [ODataRoute("Master({playerID})/Salaries")]
        public IQueryable<Salary> GetSalaries([FromODataUri] string playerId)
        {
            return _db.Master.Where(p => p.PlayerId == playerId).SelectMany(p => p.Salaries);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}