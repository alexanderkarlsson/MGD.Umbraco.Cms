using System;
using System.Collections.Generic;
using System.Linq;
using MGD.Umbraco.Cms.ModelsBuilder.Models;
using Umbraco.Core.Composing;
using Umbraco.Core.Logging;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace MGD.Umbraco.Cms.Core.Mappers
{
    public class MenuMapper
    {
        public List<MenuItemApiModel> Map(List<IPublishedContent> items, bool levelFromPage = false, MenuItemApiModel parent = null, int level = 1)
        {
            var modelItems = new List<MenuItemApiModel>();
            foreach (var item in items)
            {
                var modelItem = Map(item, parent, levelFromPage, level);
                if (modelItem != null)
                {
                    modelItems.Add(modelItem);
                }
            }
            return modelItems;
        }

        public List<MenuItemApiModel> Map(List<MenuItem> items, bool levelFromPage = false, MenuItemApiModel parent = null, int level = 1)
        {
            var modelItems = new List<MenuItemApiModel>();
            foreach (var item in items)
            {
                var modelItem = Map(item, parent, levelFromPage, level);
                if (modelItem != null)
                {
                    modelItems.Add(modelItem);
                }
            }
            return modelItems;
        }

        /// <summary>
        /// Maps an Umbraco page to a menuitem model
        /// </summary>
        /// <param name="item">The umbraco page that we want to map</param>
        /// <param name="parent">The parent page to the item page</param>
        /// <param name="levelFromPage">If we want to take the level from the umbraco page</param>
        /// <param name="level">The level on the page</param>
        /// <returns></returns>
        public MenuItemApiModel Map(IPublishedContent item, MenuItemApiModel parent, bool levelFromPage, int level)
        {
            // Init
            var model = new MenuItemApiModel();

            try
            {
                // Map base
                if (item != null)
                {
                    model.Id = item.Id;
                    model.Name = item.Name;
                    model.Url = item.Url;
                    model.UrlWithDomain = item.Url(mode: UrlMode.Absolute);

                    // Sets the level from the Umbraco page or the level someone have decared as a parameter
                    model.Level = levelFromPage ? item.Level : level;

                    model.Children = Map(item.Children.Where(i => i.IsVisible()).ToList(),
                        levelFromPage, model, level + 1);
                }
            }
            catch (Exception e)
            {
                Current.Logger.Error<MenuMapper>($"Error in menu mapper, page id:{item?.Id}", e);
                return null;
            }

            return model;
        }

        public MenuItemApiModel Map(MenuItem item, MenuItemApiModel parent, bool levelFromPage, int level)
        {
            // Init
            var model = new MenuItemApiModel();

            try
            {
                if (item is MenuItem menuItem && menuItem.Link != null)
                {
                    var link = menuItem.Link;

                    model.Id = link.Id;
                    model.Name = link.Name;
                    model.Url = link.Url;
                    model.UrlWithDomain = link.Url(mode: UrlMode.Absolute);

                    // Sets the level from the Umbraco page or the level someone have declared as a parameter
                    if (link != null && levelFromPage)
                        model.Level = link.Level;
                    else
                        model.Level = level;

                    model.Children = new List<MenuItemApiModel>();

                    // Add the manual child menu
                    var children = menuItem.MenuChildren != null ? menuItem.MenuChildren.Where(c => c.Link != null).ToList() : new List<MenuItem>();
                    model.Children = Map(children, levelFromPage, model, level + 1);

                    // If the Get automatic children is true, add does later in the menu
                    if (menuItem.AutoGenerateChildren)
                    {
                        var pageChildren = Map(link.Children.Where(i => i.IsVisible()).ToList(), levelFromPage, model, level + 1);
                        model.Children.AddRange(pageChildren);
                    }
                }
            }
            catch (Exception e)
            {
                Current.Logger.Error<MenuMapper>($"Error in menu mapper", e);
                return null;
            }

            return model;
        }
    }
    public class MenuItemApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public List<MenuItemApiModel> Children { get; set; }
        public string UrlWithDomain { get; set; }
        public int Level { get; set; }
    }
}
