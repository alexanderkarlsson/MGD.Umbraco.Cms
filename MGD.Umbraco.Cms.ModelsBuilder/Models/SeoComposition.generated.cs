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
	// Mixin Content Type with alias "seoComposition"
	/// <summary>Seo composition</summary>
	public partial interface ISeoComposition : IPublishedContent
	{
		/// <summary>Metadata description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		string MetadataDescription { get; }

		/// <summary>Metadata title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		string MetadataTitle { get; }
	}

	/// <summary>Seo composition</summary>
	[PublishedModel("seoComposition")]
	public partial class SeoComposition : PublishedContentModel, ISeoComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "seoComposition";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SeoComposition, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SeoComposition(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Metadata description: The description should optimally be between 150-160
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metadataDescription")]
		public string MetadataDescription => GetMetadataDescription(this);

		/// <summary>Static getter for Metadata description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static string GetMetadataDescription(ISeoComposition that) => that.Value<string>("metadataDescription");

		///<summary>
		/// Metadata title: Google recommends keeping your titles between 50-60
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metadataTitle")]
		public string MetadataTitle => GetMetadataTitle(this);

		/// <summary>Static getter for Metadata title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static string GetMetadataTitle(ISeoComposition that) => that.Value<string>("metadataTitle");
	}
}