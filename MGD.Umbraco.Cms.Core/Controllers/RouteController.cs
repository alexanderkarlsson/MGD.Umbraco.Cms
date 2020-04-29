using MGD.Umbraco.Cms.Core.Converters;
using MGD.Umbraco.Cms.Core.Resolvers;
using MGD.Umbraco.Cms.Core.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace MGD.Umbraco.Cms.Core.Controllers
{
    public class RouteController : UmbracoApiController
    {
        private readonly IUmbracoService _umbracoService;

        public RouteController(IUmbracoService umbracoService)
        {
            _umbracoService = umbracoService;
        }

        [System.Web.Http.HttpGet]
        public JToken GetAllRoutes(int? rootId)
        {
            var root = rootId.HasValue ? Umbraco.Content(rootId) : Umbraco.ContentAtRoot().First();
            var descendants = root.Descendants().ToList();
            descendants.Add(root);
            descendants = _umbracoService.TypeGenericToModelsBuilderType(descendants);

            // Json settings
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new PublishedContentContractResolver(),
            };
            jsonSerializerSettings.Converters.Add(new HtmlStringConverter());
            var data = Newtonsoft.Json.JsonConvert.SerializeObject(descendants, jsonSerializerSettings);
            return JToken.Parse(data);
        }
    }
}