using System.Collections.Generic;
using MGD.Umbraco.Cms.Core.Converters;
using MGD.Umbraco.Cms.Core.Resolvers;
using MGD.Umbraco.Cms.Core.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using Newtonsoft.Json.Serialization;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace MGD.Umbraco.Cms.Core.Controllers
{
    [PluginController("CmsApi")]
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
            CultureHelper.Set("en-us");
            var routes = new List<RouteApiViewModel>();
            var root = rootId.HasValue ? Umbraco.Content(rootId) : Umbraco.ContentAtRoot().First();
            var descendants = root.Descendants().ToList();
            descendants.Add(root);
            descendants = _umbracoService.TypeGenericToModelsBuilderType(descendants);
            foreach (var publishedContent in descendants)
            {
                var route = Mapper.Map<IPublishedContent, RouteApiViewModel>(publishedContent);
                if (route != null)
                {
                    routes.Add(route);
                }
            }

            // Json settings
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var data = Newtonsoft.Json.JsonConvert.SerializeObject(routes, jsonSerializerSettings);
            return JToken.Parse(data);
        }
    }

    public class RouteApiViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Alias { get; set; }
        
    }
}