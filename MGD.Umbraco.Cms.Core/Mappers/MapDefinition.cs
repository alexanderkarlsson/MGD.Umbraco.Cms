using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGD.Umbraco.Cms.Core.Controllers;
using Umbraco.Core;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.PublishedContent;

namespace MGD.Umbraco.Cms.Core.Mappers
{
    public class MapDefinition : IMapDefinition
    {
        public void DefineMaps(UmbracoMapper mapper)
        {
            mapper.Define<IPublishedContent, RouteApiViewModel>((source, context) => new RouteApiViewModel(), new RouteMapper().Map);
        }
    }
}