using MGD.Umbraco.Cms.Core.Helpers;
using MGD.Umbraco.Cms.Core.Mappers;
using MGD.Umbraco.Cms.ModelsBuilder.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace MGD.Umbraco.Cms.Core.Controllers
{
    [PluginController("CmsApi")]
    public class MenuController : UmbracoApiController
    {
        [System.Web.Http.HttpGet]
        public JToken GetMainMenu(string culture = "en-us")
        {
            CultureHelper.Set(culture);
            var menuMapper = new MenuMapper();
            var menu = GetMenu();
            var menuApiModel = menuMapper.Map(menu, level: 2);
            
            // Json settings
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var data = Newtonsoft.Json.JsonConvert.SerializeObject(menuApiModel, jsonSerializerSettings);
            return JToken.Parse(data);
        }

        private List<MenuItem> GetMenu()
        {
            var homePage = Umbraco.ContentAtRoot().First();
            if (homePage != null)
            {
                var menu = homePage.Value<List<MenuItem>>(Infer.Property<HomePage>(p => p.Menu), fallback: Fallback.ToLanguage);
                menu = menu.Where(p => p.Link != null && !string.IsNullOrEmpty(p.Link.Name)).ToList();
                return menu;
            }
            return new List<MenuItem>();
        }
    }
}