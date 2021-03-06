//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace MGD.Umbraco.Cms.ModelsBuilder.Models
{
	/// <summary>Home page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel, IOpenGraphComposition, ISeoComposition, ISitemapComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HomePage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Blocks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("blocks")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement> Blocks => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement>>("blocks");

		///<summary>
		/// Footer links column 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("footerLinksColumn1")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> FooterLinksColumn1 => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("footerLinksColumn1");

		///<summary>
		/// Footer links column 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("footerLinksColumn2")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> FooterLinksColumn2 => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("footerLinksColumn2");

		///<summary>
		/// Footer links column 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("footerLinksColumn3")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> FooterLinksColumn3 => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("footerLinksColumn3");

		///<summary>
		/// Footer text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("footerText")]
		public global::System.Web.IHtmlString FooterText => this.Value<global::System.Web.IHtmlString>("footerText");

		///<summary>
		/// Menu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("menu")]
		public global::System.Collections.Generic.IEnumerable<global::MGD.Umbraco.Cms.ModelsBuilder.Models.MenuItem> Menu => this.Value<global::System.Collections.Generic.IEnumerable<global::MGD.Umbraco.Cms.ModelsBuilder.Models.MenuItem>>("menu");

		///<summary>
		/// Social medias
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("socialMedias")]
		public global::System.Collections.Generic.IEnumerable<global::MGD.Umbraco.Cms.ModelsBuilder.Models.SocialMediaItem> SocialMedias => this.Value<global::System.Collections.Generic.IEnumerable<global::MGD.Umbraco.Cms.ModelsBuilder.Models.SocialMediaItem>>("socialMedias");

		///<summary>
		/// Open Graph Description: If no text is set we fallback to meta description if this document type has field
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("ogDescription")]
		public string OgDescription => global::MGD.Umbraco.Cms.ModelsBuilder.Models.OpenGraphComposition.GetOgDescription(this);

		///<summary>
		/// Open Graph Image: If no image is set we fallback to teaser image if this document type has field.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("ogImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent OgImage => global::MGD.Umbraco.Cms.ModelsBuilder.Models.OpenGraphComposition.GetOgImage(this);

		///<summary>
		/// Open Graph Title: If no text is set we fallback to meta description if this document type has field
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("ogTitle")]
		public string OgTitle => global::MGD.Umbraco.Cms.ModelsBuilder.Models.OpenGraphComposition.GetOgTitle(this);

		///<summary>
		/// Metadata description: The description should optimally be between 150-160
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metadataDescription")]
		public string MetadataDescription => global::MGD.Umbraco.Cms.ModelsBuilder.Models.SeoComposition.GetMetadataDescription(this);

		///<summary>
		/// Metadata title: Google recommends keeping your titles between 50-60
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metadataTitle")]
		public string MetadataTitle => global::MGD.Umbraco.Cms.ModelsBuilder.Models.SeoComposition.GetMetadataTitle(this);

		///<summary>
		/// Hide in sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("sitemaHide")]
		public bool SitemaHide => global::MGD.Umbraco.Cms.ModelsBuilder.Models.SitemapComposition.GetSitemaHide(this);

		///<summary>
		/// Sitemap default change freqency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("sitemapDefaultChangeFreqency")]
		public string SitemapDefaultChangeFreqency => global::MGD.Umbraco.Cms.ModelsBuilder.Models.SitemapComposition.GetSitemapDefaultChangeFreqency(this);

		///<summary>
		/// Sitemap default priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("sitemapDefaultPriority")]
		public string SitemapDefaultPriority => global::MGD.Umbraco.Cms.ModelsBuilder.Models.SitemapComposition.GetSitemapDefaultPriority(this);
	}
}
