using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "306c96998237085")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home Page</summary>
	[PublishedContentModel("homePage")]
	public partial class HomePage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Search Page: RenderMVCController
		///</summary>
		[ImplementPropertyType("searchPage")]
		public IPublishedContent SearchPage
		{
			get { return this.GetPropertyValue<IPublishedContent>("searchPage"); }
		}

		///<summary>
		/// Search Surface: SurfaceController
		///</summary>
		[ImplementPropertyType("searchSurface")]
		public IPublishedContent SearchSurface
		{
			get { return this.GetPropertyValue<IPublishedContent>("searchSurface"); }
		}
	}

	/// <summary>Search Form</summary>
	[PublishedContentModel("searchForm")]
	public partial class SearchForm : PublishedContentModel, IDisplayInXmlsitemapTrueFalse
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "searchForm";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SearchForm(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SearchForm, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Change Frequency: Select how often the page is updated
		///</summary>
		[ImplementPropertyType("changeFrequency")]
		public string ChangeFrequency
		{
			get { return Umbraco.Web.PublishedContentModels.DisplayInXmlsitemapTrueFalse.GetChangeFrequency(this); }
		}

		///<summary>
		/// Display In XML Sitemap: Click to display in XML sitemap
		///</summary>
		[ImplementPropertyType("displayInXMLSitemap")]
		public bool DisplayInXmlsitemap
		{
			get { return Umbraco.Web.PublishedContentModels.DisplayInXmlsitemapTrueFalse.GetDisplayInXmlsitemap(this); }
		}
	}

	/// <summary>Settings</summary>
	[PublishedContentModel("settings")]
	public partial class Settings : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "settings";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Settings(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Settings, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Search  Page
		///</summary>
		[ImplementPropertyType("searchPage")]
		public IPublishedContent SearchPage
		{
			get { return this.GetPropertyValue<IPublishedContent>("searchPage"); }
		}
	}

	/// <summary>Layout</summary>
	[PublishedContentModel("layout")]
	public partial class Layout : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "layout";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Layout(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Layout, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Search Form Surface Controller</summary>
	[PublishedContentModel("searchFormSurfaceController")]
	public partial class SearchFormSurfaceController : PublishedContentModel, IDisplayInXmlsitemapTrueFalse
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "searchFormSurfaceController";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SearchFormSurfaceController(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SearchFormSurfaceController, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Change Frequency: Select how often the page is updated
		///</summary>
		[ImplementPropertyType("changeFrequency")]
		public string ChangeFrequency
		{
			get { return Umbraco.Web.PublishedContentModels.DisplayInXmlsitemapTrueFalse.GetChangeFrequency(this); }
		}

		///<summary>
		/// Display In XML Sitemap: Click to display in XML sitemap
		///</summary>
		[ImplementPropertyType("displayInXMLSitemap")]
		public bool DisplayInXmlsitemap
		{
			get { return Umbraco.Web.PublishedContentModels.DisplayInXmlsitemapTrueFalse.GetDisplayInXmlsitemap(this); }
		}
	}

	/// <summary>Example Doc Type</summary>
	[PublishedContentModel("exampleDocType")]
	public partial class ExampleDocType : PublishedContentModel, IDisplayInXmlsitemapTrueFalse
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "exampleDocType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ExampleDocType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ExampleDocType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Test Media Image
		///</summary>
		[ImplementPropertyType("testMediaImage")]
		public IPublishedContent TestMediaImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("testMediaImage"); }
		}

		///<summary>
		/// Test RTE
		///</summary>
		[ImplementPropertyType("testRTE")]
		public IHtmlString TestRte
		{
			get { return this.GetPropertyValue<IHtmlString>("testRTE"); }
		}

		///<summary>
		/// Test String
		///</summary>
		[ImplementPropertyType("testString")]
		public string TestString
		{
			get { return this.GetPropertyValue<string>("testString"); }
		}

		///<summary>
		/// Change Frequency: Select how often the page is updated
		///</summary>
		[ImplementPropertyType("changeFrequency")]
		public string ChangeFrequency
		{
			get { return Umbraco.Web.PublishedContentModels.DisplayInXmlsitemapTrueFalse.GetChangeFrequency(this); }
		}

		///<summary>
		/// Display In XML Sitemap: Click to display in XML sitemap
		///</summary>
		[ImplementPropertyType("displayInXMLSitemap")]
		public bool DisplayInXmlsitemap
		{
			get { return Umbraco.Web.PublishedContentModels.DisplayInXmlsitemapTrueFalse.GetDisplayInXmlsitemap(this); }
		}
	}

	/// <summary>Image Cropper</summary>
	[PublishedContentModel("imageCropper")]
	public partial class ImageCropper : PublishedContentModel, IDisplayInXmlsitemapTrueFalse
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "imageCropper";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ImageCropper(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ImageCropper, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Responsive Image Example
		///</summary>
		[ImplementPropertyType("responsiveImageExample")]
		public Umbraco.Web.Models.ImageCropDataSet ResponsiveImageExample
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("responsiveImageExample"); }
		}

		///<summary>
		/// Change Frequency: Select how often the page is updated
		///</summary>
		[ImplementPropertyType("changeFrequency")]
		public string ChangeFrequency
		{
			get { return Umbraco.Web.PublishedContentModels.DisplayInXmlsitemapTrueFalse.GetChangeFrequency(this); }
		}

		///<summary>
		/// Display In XML Sitemap: Click to display in XML sitemap
		///</summary>
		[ImplementPropertyType("displayInXMLSitemap")]
		public bool DisplayInXmlsitemap
		{
			get { return Umbraco.Web.PublishedContentModels.DisplayInXmlsitemapTrueFalse.GetDisplayInXmlsitemap(this); }
		}
	}

	/// <summary>Search Engine Sitemap</summary>
	[PublishedContentModel("searchEngineSitemap")]
	public partial class SearchEngineSitemap : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "searchEngineSitemap";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SearchEngineSitemap(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SearchEngineSitemap, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	// Mixin content Type 1085 with alias "displayInXMLSitemapTrueFalse"
	/// <summary>Display In XML Sitemap True False</summary>
	public partial interface IDisplayInXmlsitemapTrueFalse : IPublishedContent
	{
		/// <summary>Change Frequency</summary>
		string ChangeFrequency { get; }

		/// <summary>Display In XML Sitemap</summary>
		bool DisplayInXmlsitemap { get; }
	}

	/// <summary>Display In XML Sitemap True False</summary>
	[PublishedContentModel("displayInXMLSitemapTrueFalse")]
	public partial class DisplayInXmlsitemapTrueFalse : PublishedContentModel, IDisplayInXmlsitemapTrueFalse
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "displayInXMLSitemapTrueFalse";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DisplayInXmlsitemapTrueFalse(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DisplayInXmlsitemapTrueFalse, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Change Frequency: Select how often the page is updated
		///</summary>
		[ImplementPropertyType("changeFrequency")]
		public string ChangeFrequency
		{
			get { return GetChangeFrequency(this); }
		}

		/// <summary>Static getter for Change Frequency</summary>
		public static string GetChangeFrequency(IDisplayInXmlsitemapTrueFalse that) { return that.GetPropertyValue<string>("changeFrequency"); }

		///<summary>
		/// Display In XML Sitemap: Click to display in XML sitemap
		///</summary>
		[ImplementPropertyType("displayInXMLSitemap")]
		public bool DisplayInXmlsitemap
		{
			get { return GetDisplayInXmlsitemap(this); }
		}

		/// <summary>Static getter for Display In XML Sitemap</summary>
		public static bool GetDisplayInXmlsitemap(IDisplayInXmlsitemapTrueFalse that) { return that.GetPropertyValue<bool>("displayInXMLSitemap"); }
	}

	/// <summary>EnumExample</summary>
	[PublishedContentModel("enumExample")]
	public partial class EnumExample : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "enumExample";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public EnumExample(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<EnumExample, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Font Size
		///</summary>
		[ImplementPropertyType("fontSize")]
		public string FontSize
		{
			get { return this.GetPropertyValue<string>("fontSize"); }
		}

		///<summary>
		/// Section Background Colour
		///</summary>
		[ImplementPropertyType("sectionBackgroundColour")]
		public Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor SectionBackgroundColour
		{
			get { return this.GetPropertyValue<Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>("sectionBackgroundColour"); }
		}

		///<summary>
		/// Text Colour
		///</summary>
		[ImplementPropertyType("textColour")]
		public Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor TextColour
		{
			get { return this.GetPropertyValue<Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>("textColour"); }
		}
	}

	/// <summary>Year</summary>
	[PublishedContentModel("year")]
	public partial class Year : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "year";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Year(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Year, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Archive Year
		///</summary>
		[ImplementPropertyType("archiveYear")]
		public bool ArchiveYear
		{
			get { return this.GetPropertyValue<bool>("archiveYear"); }
		}
	}

	/// <summary>Customer Booking Details</summary>
	[PublishedContentModel("customerBookingDetails")]
	public partial class CustomerBookingDetails : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "customerBookingDetails";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CustomerBookingDetails(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CustomerBookingDetails, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Booking Confirmed
		///</summary>
		[ImplementPropertyType("bookingConfirmed")]
		public bool BookingConfirmed
		{
			get { return this.GetPropertyValue<bool>("bookingConfirmed"); }
		}

		///<summary>
		/// End Date
		///</summary>
		[ImplementPropertyType("endDate")]
		public string EndDate
		{
			get { return this.GetPropertyValue<string>("endDate"); }
		}

		///<summary>
		/// Start Date
		///</summary>
		[ImplementPropertyType("startDate")]
		public string StartDate
		{
			get { return this.GetPropertyValue<string>("startDate"); }
		}
	}

	/// <summary>Bookings</summary>
	[PublishedContentModel("bookings")]
	public partial class Bookings : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "bookings";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Bookings(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Bookings, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
