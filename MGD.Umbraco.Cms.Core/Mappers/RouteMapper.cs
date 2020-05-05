using System.Linq;
using MGD.Umbraco.Cms.Core.Controllers;
using MGD.Umbraco.Cms.ModelsBuilder.Models;
using Umbraco.Core;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

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
            target.MetadataTitle = GetMetadataTitle(source);
        }

        private string GetMetadataTitle(IPublishedContent publishedContent)
        {
            var homePage = publishedContent.Root();
            var siteSettings = homePage.Siblings<SiteSettings>().FirstOrDefault();

            // Home page
            if (publishedContent.Id == homePage.Id)
            {
                return publishedContent.Value<string>("metadataTitle");
            }

            // Any other page
            var metaTitle = $"{publishedContent.Value<string>("metadataTitle").OrIfNullOrWhiteSpace(publishedContent.Value<string>("heading"))}";
            if (string.IsNullOrEmpty(metaTitle))
            {
                metaTitle = homePage.Value<string>("metadataTitle");
            }

            // Place company name last
            var companyName = siteSettings?.Value<string>("companyName");
            if (!string.IsNullOrEmpty(companyName))
            {
                return $"{metaTitle} | {companyName}";
            }

            return metaTitle;
        }
    }
}