using System.Collections.Generic;
using System.Linq;
using MGD.Umbraco.Cms.Core.Converters;
using MGD.Umbraco.Cms.Core.Resolvers;
using MGD.Umbraco.Cms.Core.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace MGD.Umbraco.Cms.Core.Controllers
{
    [PluginController("CmsApi")]
    public class PagesController : UmbracoApiController
    {
        private readonly IUmbracoService _umbracoService;

        public PagesController(IUmbracoService umbracoService)
        {
            _umbracoService = umbracoService;
        }

        [System.Web.Http.HttpGet]
        public JToken GetPage(int? id, string culture = "en-us")
        {
            CultureHelper.Set(culture);

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

        [System.Web.Http.HttpGet]
        public JToken GetPages(List<int> ids, string culture = "en-us")
        {
            CultureHelper.Set(culture);

            // Get data and type it
            var pages = _umbracoService.TypeGenericToModelsBuilderType(Umbraco.Content(ids).ToList());

            // Json settings
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new PublishedContentContractResolver(),
            };
            jsonSerializerSettings.Converters.Add(new HtmlStringConverter());
            var data = Newtonsoft.Json.JsonConvert.SerializeObject(pages, jsonSerializerSettings);
            return JToken.Parse(data);
        }
    }
}