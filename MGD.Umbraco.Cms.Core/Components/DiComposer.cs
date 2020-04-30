using MGD.Umbraco.Cms.Core.Mappers;
using MGD.Umbraco.Cms.Core.Services;
using System.Net.Http;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;

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
                .Add<MapDefinition>();
        }
    }
}