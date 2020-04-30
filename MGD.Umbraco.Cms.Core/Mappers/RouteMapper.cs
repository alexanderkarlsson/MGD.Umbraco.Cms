using MGD.Umbraco.Cms.Core.Controllers;
using Umbraco.Core;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.PublishedContent;

namespace MGD.Umbraco.Cms.Core.Mappers
{
    public class RouteMapper
    {
        public void Map(IPublishedContent source, RouteApiViewModel target, MapperContext context)
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Url = source.Url;
            target.Alias = source.ContentType.Alias.ToFirstUpper();
        }
    }
}
