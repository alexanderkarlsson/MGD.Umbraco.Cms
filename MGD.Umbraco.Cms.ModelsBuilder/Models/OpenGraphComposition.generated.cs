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
	// Mixin Content Type with alias "openGraphComposition"
	/// <summary>Open graph composition</summary>
	public partial interface IOpenGraphComposition : IPublishedContent
	{
		/// <summary>Open Graph Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		string OgDescription { get; }

		/// <summary>Open Graph Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent OgImage { get; }

		/// <summary>Open Graph Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		string OgTitle { get; }
	}

	/// <summary>Open graph composition</summary>
	[PublishedModel("openGraphComposition")]
	public partial class OpenGraphComposition : PublishedContentModel, IOpenGraphComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "openGraphComposition";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OpenGraphComposition, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public OpenGraphComposition(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Open Graph Description: If no text is set we fallback to meta description if this document type has field
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("ogDescription")]
		public string OgDescription => GetOgDescription(this);

		/// <summary>Static getter for Open Graph Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static string GetOgDescription(IOpenGraphComposition that) => that.Value<string>("ogDescription");

		///<summary>
		/// Open Graph Image: If no image is set we fallback to teaser image if this document type has field.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("ogImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent OgImage => GetOgImage(this);

		/// <summary>Static getter for Open Graph Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetOgImage(IOpenGraphComposition that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("ogImage");

		///<summary>
		/// Open Graph Title: If no text is set we fallback to meta description if this document type has field
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("ogTitle")]
		public string OgTitle => GetOgTitle(this);

		/// <summary>Static getter for Open Graph Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static string GetOgTitle(IOpenGraphComposition that) => that.Value<string>("ogTitle");
	}
}
