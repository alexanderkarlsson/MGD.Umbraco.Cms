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
	/// <summary>Information page</summary>
	[PublishedModel("informationPage")]
	public partial class InformationPage : PublishedContentModel, IOpenGraphComposition, ISeoComposition, ISitemapComposition, ITeaserComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "informationPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<InformationPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public InformationPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Body
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("body")]
		public global::System.Web.IHtmlString Body => this.Value<global::System.Web.IHtmlString>("body");

		///<summary>
		/// Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("heading")]
		public string Heading => this.Value<string>("heading");

		///<summary>
		/// Introduction
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("introduction")]
		public global::System.Web.IHtmlString Introduction => this.Value<global::System.Web.IHtmlString>("introduction");

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
