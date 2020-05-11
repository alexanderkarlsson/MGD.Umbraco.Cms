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
	/// <summary>Product listing page</summary>
	[PublishedModel("productListingPage")]
	public partial class ProductListingPage : PublishedContentModel, IOpenGraphComposition, ISeoComposition, ISitemapComposition, ITeaserComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "productListingPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProductListingPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ProductListingPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Blocks: Blocks before product list
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("blocks")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement> Blocks => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement>>("blocks");

		///<summary>
		/// Description - block one: On the botton of the page we have a description of the page, this is block one.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("bodyPartOne")]
		public global::System.Web.IHtmlString BodyPartOne => this.Value<global::System.Web.IHtmlString>("bodyPartOne");

		///<summary>
		/// Description - block two: On the botton of the page we have a description of the page, this is block two.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("bodyPartTwo")]
		public global::System.Web.IHtmlString BodyPartTwo => this.Value<global::System.Web.IHtmlString>("bodyPartTwo");

		///<summary>
		/// Footer blocks: Blocks after product list
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("footerBlocks")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement> FooterBlocks => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement>>("footerBlocks");

		///<summary>
		/// Product filters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("productFilters")]
		public global::System.Collections.Generic.IEnumerable<global::MGD.Umbraco.Cms.ModelsBuilder.Models.ProductSearchFilter> ProductFilters => this.Value<global::System.Collections.Generic.IEnumerable<global::MGD.Umbraco.Cms.ModelsBuilder.Models.ProductSearchFilter>>("productFilters");

		///<summary>
		/// Teaser Icon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("teaserIcon")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent TeaserIcon => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("teaserIcon");

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

		///<summary>
		/// Teaser heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("teaserHeading")]
		public string TeaserHeading => global::MGD.Umbraco.Cms.ModelsBuilder.Models.TeaserComposition.GetTeaserHeading(this);

		///<summary>
		/// Teaser image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("teaserImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent TeaserImage => global::MGD.Umbraco.Cms.ModelsBuilder.Models.TeaserComposition.GetTeaserImage(this);

		///<summary>
		/// Teaser introduction
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("teaserIntroduction")]
		public global::System.Web.IHtmlString TeaserIntroduction => global::MGD.Umbraco.Cms.ModelsBuilder.Models.TeaserComposition.GetTeaserIntroduction(this);
	}
}