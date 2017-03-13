using BaseballHistoryAPI.Models;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BaseballHistoryAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            var jsonSerializerSettings = config.Formatters.JsonFormatter.SerializerSettings;
            jsonSerializerSettings.Formatting = Formatting.None;
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API configuration and services
            var allowedCors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(allowedCors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<AllstarFull>("AllstarFull").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.gameID);
            builder.EntitySet<Appearance>("Appearances").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID);
            builder.EntitySet<AwardsManager>("AwardsManagers").EntityType.HasKey(p => p.playerID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.awardID);
            builder.EntitySet<AwardsPlayer>("AwardsPlayers").EntityType.HasKey(p => p.playerID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.awardID);
            builder.EntitySet<AwardsShareManager>("AwardsShareManagers").EntityType.HasKey(p => p.playerID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.awardID);
            builder.EntitySet<AwardsSharePlayer>("AwardsSharePlayers").EntityType.HasKey(p => p.playerID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.awardID);
            builder.EntitySet<Batting>("Batting").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.stint);
            builder.EntitySet<BattingPost>("BattingPost").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.round);
            builder.EntitySet<CollegePlaying>("CollegePlaying").EntityType.HasKey(p => p.playerID).HasKey(p => p.yearID).HasKey(p => p.schoolID);
            builder.EntitySet<Fielding>("Fielding").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.stint).HasKey(p => p.POS);
            builder.EntitySet<FieldingOF>("FieldingOF").EntityType.HasKey(p => p.playerID).HasKey(p => p.yearID).HasKey(p => p.stint);
            builder.EntitySet<FieldingOFsplit>("FieldingOFsplit").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.stint).HasKey(p => p.POS);
            builder.EntitySet<FieldingPost>("FieldingPost").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.round).HasKey(p => p.POS);
            builder.EntitySet<HallOfFame>("HallOfFame").EntityType.HasKey(p => p.playerID).HasKey(p => p.yearid).HasKey(p => p.votedBy);
            builder.EntitySet<HomeGame>("HomeGames").EntityType.HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.parkkey);
            builder.EntitySet<Manager>("Managers").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.inseason);
            builder.EntitySet<ManagersHalf>("ManagersHalf").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.inseason).HasKey(p => p.half);
            builder.EntitySet<Master>("Master").EntityType.HasKey(p => p.playerID);
            builder.EntitySet<Park>("Parks").EntityType.HasKey(p => p.ID);
            builder.EntitySet<Pitching>("Pitching").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.stint);
            builder.EntitySet<PitchingPost>("PitchingPost").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.round);
            builder.EntitySet<Salary>("Salaries").EntityType.HasKey(p => p.playerID).HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID);
            builder.EntitySet<School>("Schools").EntityType.HasKey(p => p.schoolID);
            builder.EntitySet<SeriesPost>("SeriesPost").EntityType.HasKey(p => p.teamIDwinner).HasKey(p => p.lgIDwinner).HasKey(p => p.yearID).HasKey(p => p.round);
            builder.EntitySet<Team>("Teams").EntityType.HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID);
            builder.EntitySet<TeamFranchise>("TeamFranchises").EntityType.HasKey(p => p.franchID);
            builder.EntitySet<TeamsHalf>("TeamsHalf").EntityType.HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID).HasKey(p => p.Half);
            builder.EntitySet<PlayerBattingTotal>("PlayerBattingTotals").EntityType.HasKey(p => p.playerID);
            builder.EntitySet<PlayerFieldingTotal>("PlayerFieldingTotals").EntityType.HasKey(p => p.playerID).HasKey(p => p.POS);
            builder.EntitySet<PlayerPitchingTotal>("PlayerPitchingTotals").EntityType.HasKey(p => p.playerID);
            builder.EntitySet<TeamBattingTotal>("TeamBattingTotals").EntityType.HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID);
            builder.EntitySet<TeamFieldingTotal>("TeamFieldingTotals").EntityType.HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID);
            builder.EntitySet<TeamPitchingTotal>("TeamPitchingTotals").EntityType.HasKey(p => p.teamID).HasKey(p => p.lgID).HasKey(p => p.yearID);

            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
