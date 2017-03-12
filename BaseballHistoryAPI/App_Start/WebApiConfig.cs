using BaseballHistoryAPI.Models;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace BaseballHistoryAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<AllstarFull>("AllstarFull");
            builder.EntitySet<Appearance>("Appearances");
            builder.EntitySet<AwardsManager>("AwardsManagers");
            builder.EntitySet<AwardsPlayer>("AwardsPlayers");
            builder.EntitySet<AwardsShareManager>("AwardsShareManagers");
            builder.EntitySet<AwardsSharePlayer>("AwardsSharePlayers");
            builder.EntitySet<Batting>("Batting");
            builder.EntitySet<BattingPost>("BattingPost");
            builder.EntitySet<CollegePlaying>("CollegePlaying");
            builder.EntitySet<Fielding>("Fielding");
            builder.EntitySet<FieldingOF>("FieldingOF");
            builder.EntitySet<FieldingOFsplit>("FieldingOFsplit");
            builder.EntitySet<FieldingPost>("FieldingPost");
            builder.EntitySet<HallOfFame>("HallOfFame");
            builder.EntitySet<HomeGame>("HomeGame");
            builder.EntitySet<Manager>("Managers");
            builder.EntitySet<ManagersHalf>("ManagersHalf");
            builder.EntitySet<Master>("Master");
            builder.EntitySet<Park>("Parks");
            builder.EntitySet<Pitching>("Pitching");
            builder.EntitySet<PitchingPost>("PitchingPost");
            builder.EntitySet<Salary>("Salaries");
            builder.EntitySet<School>("Schools");
            builder.EntitySet<SeriesPost>("SeriesPost");
            builder.EntitySet<Team>("Teams");
            builder.EntitySet<TeamsFranchise>("TeamsFranchises");
            builder.EntitySet<TeamsHalf>("TeamsHalf");
            builder.EntitySet<PlayerBattingTotal>("PlayerBattingTotals");
            builder.EntitySet<PlayerFieldingTotal>("PlayerFieldingTotals");
            builder.EntitySet<PlayerPitchingTotal>("PlayerPitchingTotals");
            builder.EntitySet<TeamBattingTotal>("TeamBattingTotals");
            builder.EntitySet<TeamFieldingTotal>("TeamFieldingTotals");
            builder.EntitySet<TeamPitchingTotal>("TeamPitchingTotals");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
