﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.Kentico;

[assembly: RegisterDocumentType(HomeSection.CLASS_NAME, typeof(HomeSection))]

namespace CMS.DocumentEngine.Types.Kentico
{
    /// <summary>
    /// Represents a content item of type HomeSection.
    /// </summary>
    public partial class HomeSection : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Kentico.HomeSection";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeSection fields.
		/// </summary>
		private readonly HomeSectionFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeSectionID.
		/// </summary>
		[DatabaseIDField]
		public int HomeSectionID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeSectionID"), 0);
			}
			set
			{
				SetValue("HomeSectionID", value);
			}
		}


		/// <summary>
		/// Title.
		/// </summary>
		[DatabaseField]
		public string Title
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Title"), @"");
			}
			set
			{
				SetValue("Title", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string Text
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Text"), @"");
			}
			set
			{
				SetValue("Text", value);
			}
		}


		/// <summary>
		/// Link.
		/// </summary>
		[DatabaseField]
		public string Link
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Link"), @"");
			}
			set
			{
				SetValue("Link", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomeSection fields.
		/// </summary>
		[RegisterProperty]
		public HomeSectionFields Fields
		{
			get
			{
				return mFields;
			}
		}

      

        /// <summary>
        /// Provides extended API for working with HomeSection fields.
        /// </summary>
        [RegisterAllProperties]
		public partial class HomeSectionFields : AbstractHierarchicalObject<HomeSectionFields>
		{
			/// <summary>
			/// The content item of type HomeSection that is a target of the extended API.
			/// </summary>
			private readonly HomeSection mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeSectionFields" /> class with the specified content item of type HomeSection.
			/// </summary>
			/// <param name="instance">The content item of type HomeSection that is a target of the extended API.</param>
			public HomeSectionFields(HomeSection instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeSectionID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeSectionID;
				}
				set
				{
					mInstance.HomeSectionID = value;
				}
			}


			/// <summary>
			/// Title.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.Title;
				}
				set
				{
					mInstance.Title = value;
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.Text;
				}
				set
				{
					mInstance.Text = value;
				}
			}


			/// <summary>
			/// Link.
			/// </summary>
			public string Link
			{
				get
				{
					return mInstance.Link;
				}
				set
				{
					mInstance.Link = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeSection" /> class.
		/// </summary>
		public HomeSection() : base(CLASS_NAME)
		{
			mFields = new HomeSectionFields(this);
		}

		#endregion
	}
}