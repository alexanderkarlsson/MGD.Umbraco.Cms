using Swashbuckle.Application;
using Swashbuckle.Swagger;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Umbraco.Core.Composing;

namespace MGD.Umbraco.Cms.Core.Components
{
    public class SwaggerComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            GlobalConfiguration
                .Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Mardi Gras Digital - Umbraco API");
                    c.ResolveConflictingActions(a => a.First());
                    c.DocumentFilter<SwaggerDocumentFilter>();
                })
                .EnableSwaggerUi();
        }
    }
    public class SwaggerDocumentFilter : IDocumentFilter
    {
        public void Apply(
            SwaggerDocument swaggerDoc,
            SchemaRegistry schemaRegistry,
            IApiExplorer apiExplorer)
        {
            swaggerDoc.paths = swaggerDoc
                .paths
                .Where(x => x.Key.ToLower().StartsWith("/umbraco/cmsapi"))
                .ToDictionary(e => e.Key, e => e.Value);
            
            // Remove the paths id in swagger
            foreach (var pathsValue in swaggerDoc.paths.Values)
            {
                if (pathsValue.get.parameters != null)
                {
                    pathsValue.get.parameters = pathsValue.get.parameters.Where(a => a.@in != "path").ToList();
                }
            }
        }
    }
}