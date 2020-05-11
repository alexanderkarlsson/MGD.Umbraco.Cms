using System;
using MGD.Umbraco.Cms.Core.Helpers;
using MGD.Umbraco.Cms.Core.Mappers;
using MGD.Umbraco.Cms.ModelsBuilder.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;
using MGD.StructuredDictionary;
using Umbraco.Core.Composing;
using Umbraco.Core.Models;

namespace MGD.Umbraco.Cms.Core.Controllers
{
    [PluginController("CmsApi")]
    public class TextController : UmbracoApiController
    {
        [System.Web.Http.HttpGet]
        public JToken GetAllTexts(string culture = "en-us")
        {
            CultureHelper.Set(culture);

            var rootDictionaryItems = Current.Services.LocalizationService.GetRootDictionaryItems();
            var texts = new Dictionary<string,string>();
            foreach (var rootDictionaryItem in rootDictionaryItems)
            {
                var value = GetDictionaryValue(rootDictionaryItem, culture);
                if (value != null)
                {
                    texts.Add(value.Item1, value.Item2);
                }

                var descendants = Current.Services.LocalizationService.GetDictionaryItemDescendants(rootDictionaryItem.Key);
                foreach (var descendant in descendants)
                {
                    value = GetDictionaryValue(descendant, culture);
                    if (value != null)
                    {
                        texts.Add(value.Item1, value.Item2);
                    }
                }
            }

            // Json settings
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var data = Newtonsoft.Json.JsonConvert.SerializeObject(texts, jsonSerializerSettings);
            return JToken.Parse(data);
        }

        /// <summary>
        /// TODO: We must lock this endpoint out
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fallback"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public string GetText(string key, string fallback = "", string culture = "en-us")
        {
            CultureHelper.Set(culture);
            var text = TextHelper.Translate(key, fallback);
            return text;
        }

        private Tuple<string, string> GetDictionaryValue(IDictionaryItem dictionaryItem, string culture)
        {
            var key = dictionaryItem.ItemKey;
            var value = dictionaryItem.Translations.FirstOrDefault(t => t?.Language.IsoCode.ToLower() == culture.ToLower())?.Value;
            if (!string.IsNullOrEmpty(value))
            {
                return new Tuple<string, string>(key, value);
            }

            return null;
        }
    }
}