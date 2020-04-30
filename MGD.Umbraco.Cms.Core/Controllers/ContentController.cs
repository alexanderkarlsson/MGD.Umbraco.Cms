using MGD.Umbraco.Cms.Core.Converters;
using MGD.Umbraco.Cms.Core.Resolvers;
using MGD.Umbraco.Cms.Core.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Umbraco.Web.WebApi;

namespace MGD.Umbraco.Cms.Core.Controllers
{
    public class ContentController : UmbracoApiController
    {
        private readonly IUmbracoService _umbracoService;

        public ContentController(IUmbracoService umbracoService)
        {
            _umbracoService = umbracoService;
        }

        [System.Web.Http.HttpGet]
        public JToken GetPage(int id)
        {
            CultureHelper.Set("en-us");

            // Get data and type it
            var page = _umbracoService.TypeGenericToModelsBuilderType(Umbraco.Content(id));

            // Json settings
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new PublishedContentContractResolver(),
            };
            jsonSerializerSettings.Converters.Add(new HtmlStringConverter());
            var data = Newtonsoft.Json.JsonConvert.SerializeObject(page, jsonSerializerSettings);
            return JToken.Parse(data);
        }
    }
}