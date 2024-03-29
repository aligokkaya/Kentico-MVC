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

using System;
namespace CMS.DocumentEngine.Types.Kentico
{
	/// <summary>
	/// Provides methods for retrieving pages of type Doctor.
	/// </summary>
	public partial class DoctorProvider
	{
		/// <summary>
		/// Returns a query that selects published pages of type Doctor.
		/// </summary>
		public static DocumentQuery<Doctor> GetDoctors()
		{
			return DocumentHelper.GetDocuments<Doctor>().PublishedVersion().Published();
		}


		/// <summary>
		/// Returns a published page of type Doctor that matches the specified criteria.
		/// </summary>
		/// <param name="nodeId">The identifier of the content tree node that represents the page.</param>
		/// <param name="siteName">The name of the site where the page belongs.</param>
		/// <param name="cultureName">The name of the language, e.g. en-US, that determines which localized version should be retrieved.</param>
		public static DocumentQuery<Doctor> GetDoctor(int nodeId, string cultureName, string siteName)
		{
			return GetDoctors().OnSite(siteName).Culture(cultureName).WhereEquals("NodeID", nodeId);
		}


		/// <summary>
		/// Returns a published page of type Doctor that matches the specified criteria.
		/// </summary>
		/// <param name="nodeGuid">The globally unique identifier of the content tree node that represents the page.</param>
		/// <param name="siteName">The name of the site where the page belongs.</param>
		/// <param name="cultureName">The name of the language, e.g. en-US, that determines which localized version should be retrieved.</param>
		public static DocumentQuery<Doctor> GetDoctor(Guid nodeGuid, string cultureName, string siteName)
		{
			return GetDoctors().OnSite(siteName).Culture(cultureName).WhereEquals("NodeGUID", nodeGuid);
		}


		/// <summary>
		/// Returns a published page of type Doctor that matches the specified criteria.
		/// </summary>
		/// <param name="nodeAliasPath">The alias path to the content tree node that represents the page.</param>
		/// <param name="siteName">The name of the site where the page belongs.</param>
		/// <param name="cultureName">The name of the language, e.g. en-US, that determines which localized version should be retrieved.</param>
		public static DocumentQuery<Doctor> GetDoctor(string nodeAliasPath, string cultureName, string siteName)
		{
			return GetDoctors().OnSite(siteName).Culture(cultureName).Path(nodeAliasPath);
		}

        internal static object GetDoctor()
        {
            throw new NotImplementedException();
        }
    }
}