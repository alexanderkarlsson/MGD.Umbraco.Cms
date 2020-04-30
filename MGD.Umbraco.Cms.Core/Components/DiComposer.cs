using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MGD.Umbraco.Cms.Core.Controllers;
using MGD.Umbraco.Cms.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace MGD.Umbraco.Cms.Core.Components
{
    public class DiComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            // Services
            composition.Register<IUmbracoService, UmbracoService>(Lifetime.Singleton);

            // Request based
            composition.Register<HttpClient>(Lifetime.Transient);

            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>()
                .Add<HeadRestMapDefinition>();
        }
    }

    public class HeadRestMapDefinition : IMapDefinition
    {
        public void DefineMaps(UmbracoMapper mapper)
        {
            mapper.Define<IPublishedContent, RouteApiViewModel>((source, context) => new RouteApiViewModel(), Map);
        }

        private void Map(IPublishedContent source, RouteApiViewModel target, MapperContext context)
        {
            target.Url = source.Url;
        }

    }
}
