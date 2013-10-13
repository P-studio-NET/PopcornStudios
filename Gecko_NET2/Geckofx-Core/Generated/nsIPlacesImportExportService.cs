// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIPlacesImportExportService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// The PlacesImportExport interface provides methods for exporting Places data.
    /// The word "Import" is in the name for legacy reasons and was kept to avoid
    /// disrupting potential extension code using the export part. The new importer
    /// lives in BookmarkHTMLUtils.jsm.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("47a4a09e-c708-4e68-b2f2-664d982ce026")]
	public interface nsIPlacesImportExportService
	{
		
		/// <summary>
        /// Saves the current bookmarks hierarchy to a bookmarks.html file.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExportHTMLToFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
		
		/// <summary>
        /// Backup the bookmarks.html file.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BackupBookmarksFile();
	}
}