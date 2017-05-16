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

            // Enable OData $count, $filter, $orderby, $expand, $select and $maxtop
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<AllstarFull>("AllstarFull").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.GameId);
            builder.EntitySet<Appearance>("Appearances").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId);
            builder.EntitySet<AwardsManager>("AwardsManagers").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.AwardId);
            builder.EntitySet<AwardsPlayer>("AwardsPlayers").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.AwardId);
            builder.EntitySet<AwardsShareManager>("AwardsShareManagers").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.AwardId);
            builder.EntitySet<AwardsSharePlayer>("AwardsSharePlayers").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.AwardId);
            builder.EntitySet<Batting>("Batting").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Stint);
            builder.EntitySet<BattingPost>("BattingPost").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Round);
            builder.EntitySet<CollegePlaying>("CollegePlaying").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.YearId).HasKey(p => p.SchoolId);
            builder.EntitySet<Fielding>("Fielding").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Stint).HasKey(p => p.Pos);
            builder.EntitySet<FieldingOf>("FieldingOF").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.YearId).HasKey(p => p.Stint);
            builder.EntitySet<FieldingOFsplit>("FieldingOFsplit").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Stint).HasKey(p => p.Pos);
            builder.EntitySet<FieldingPost>("FieldingPost").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Round).HasKey(p => p.Pos);
            builder.EntitySet<HallOfFame>("HallOfFame").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.Yearid).HasKey(p => p.VotedBy);
            builder.EntitySet<HomeGame>("HomeGames").EntityType.HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Parkkey);
            builder.EntitySet<Manager>("Managers").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Inseason);
            builder.EntitySet<ManagersHalf>("ManagersHalf").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Inseason).HasKey(p => p.Half);
            builder.EntitySet<Master>("Master").EntityType.HasKey(p => p.PlayerId);
            builder.EntitySet<Park>("Parks").EntityType.HasKey(p => p.Id);
            builder.EntitySet<Pitching>("Pitching").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Stint);
            builder.EntitySet<PitchingPost>("PitchingPost").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Round);
            builder.EntitySet<Salary>("Salaries").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId);
            builder.EntitySet<School>("Schools").EntityType.HasKey(p => p.SchoolId);
            builder.EntitySet<SeriesPost>("SeriesPost").EntityType.HasKey(p => p.TeamIDwinner).HasKey(p => p.LgIDwinner).HasKey(p => p.YearId).HasKey(p => p.Round);
            builder.EntitySet<Team>("Teams").EntityType.HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId);
            builder.EntitySet<TeamFranchise>("TeamFranchises").EntityType.HasKey(p => p.FranchId);
            builder.EntitySet<TeamsHalf>("TeamsHalf").EntityType.HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId).HasKey(p => p.Half);
            builder.EntitySet<PlayerBattingTotal>("PlayerBattingTotals").EntityType.HasKey(p => p.PlayerId);
            builder.EntitySet<PlayerFieldingTotal>("PlayerFieldingTotals").EntityType.HasKey(p => p.PlayerId).HasKey(p => p.Pos);
            builder.EntitySet<PlayerPitchingTotal>("PlayerPitchingTotals").EntityType.HasKey(p => p.PlayerId);
            builder.EntitySet<TeamBattingTotal>("TeamBattingTotals").EntityType.HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId);
            builder.EntitySet<TeamFieldingTotal>("TeamFieldingTotals").EntityType.HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId);
            builder.EntitySet<TeamPitchingTotal>("TeamPitchingTotals").EntityType.HasKey(p => p.TeamId).HasKey(p => p.LgId).HasKey(p => p.YearId);

            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
