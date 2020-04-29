using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;

namespace MGD.Umbraco.Cms.Core.Services
{
    public interface IUmbracoService
    {
        Dictionary<string, Type> GetModelsBuilderTypes();
        IPublishedContent TypeGenericToModelsBuilderType(IPublishedContent publishedContent);
        List<IPublishedContent> TypeGenericToModelsBuilderType(List<IPublishedContent> list);
    }

    public class UmbracoService : IUmbracoService
    {
        public static Dictionary<string, Type> Types { get; set; }
        public UmbracoService()
        {
            Types = GetContentModelTypes().ToDictionary(t => CreateDocumentTypeAliasFromTypeName(t.Name), t => t);
        }

        public Dictionary<string, Type> GetModelsBuilderTypes()
        {
            return Types;
        }

        public List<IPublishedContent> TypeGenericToModelsBuilderType(List<IPublishedContent> list)
        {
            var typedList = new List<IPublishedContent>();
            foreach (var publishedContent in list)
            {
                var typedContent = TypeGenericToModelsBuilderType(publishedContent);
                if (typedContent != null)
                {
                    typedList.Add(typedContent);
                }
            }

            return typedList;
        }

        public IPublishedContent TypeGenericToModelsBuilderType(IPublishedContent publishedContent)
        {
            var types = GetModelsBuilderTypes();
            if (types.TryGetValue(publishedContent.ContentType.Alias, out Type type))
            {
                return (IPublishedContent)Activator.CreateInstance(type, publishedContent);
            }

            return null;
        }

        private static IEnumerable<Type> GetContentModelTypes()
        {
            var assembly = AppDomain.CurrentDomain.GetAssemblies().First(a => a.FullName.Contains("MGD.Umbraco.Cms.ModelsBuilder"));
            return assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(PublishedContentModel)));
        }

        private static string CreateDocumentTypeAliasFromTypeName(string typeName)
        {
            var firstCharLowerCased = char.ToLowerInvariant(typeName[0]) + typeName.Substring(1);

            return firstCharLowerCased.Replace("ContentModel", string.Empty);
        }
    }
}