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
// Generated by IDLImporter from file nsIStrictTransportSecurityService.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("16955eee-6c48-4152-9309-c42a465138a1")]
	public interface nsIStrictTransportSecurityService
	{
		
		/// <summary>
        /// Parses a given HTTP header and records the results internally.
        /// The format of the STS header is defined by the STS specification:
        /// http://tools.ietf.org/html/draft-hodges-strict-transport-sec
        /// and allows a host to specify that future requests on port 80 should be
        /// upgraded to HTTPS.
        ///
        /// @param aSourceURI the URI of the resource with the HTTP header.
        /// @param aHeader the HTTP response header specifying STS data.
        /// @return NS_OK            if it succeeds
        /// NS_ERROR_FAILURE if it can't be parsed
        /// NS_SUCCESS_LOSS_OF_INSIGNIFICANT_DATA
        /// if there are unrecognized tokens in the header.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ProcessStsHeader([MarshalAs(UnmanagedType.Interface)] nsIURI aSourceURI, [MarshalAs(UnmanagedType.LPStr)] string aHeader);
		
		/// <summary>
        /// Removes the STS state of a host, including the includeSubdomains state
        /// that would affect subdomains.  This essentially removes STS state for
        /// the domain tree rooted at this host.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveStsState([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Checks if the given security info is for an STS host with a broken
        /// transport layer (certificate errors like invalid CN).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ShouldIgnoreStsHeader([MarshalAs(UnmanagedType.Interface)] nsISupports aSecurityInfo);
		
		/// <summary>
        /// Checks whether or not the given hostname has STS state set.
        /// The host is an STS host if either it has the STS permission, or one of
        /// its super-domains has an STS "includeSubdomains" permission set.
        ///
        /// @param aHost the hostname (punycode) to query for STS state.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsStsHost([MarshalAs(UnmanagedType.LPStr)] string aHost);
		
		/// <summary>
        /// Checks whether or not the URI's hostname has STS state set.
        /// The URI is an STS URI if either the host has the STS permission, or one
        /// of its super-domains has an STS "includeSubdomains" permission set.
        /// NOTE: this function makes decisions based only on the scheme and
        /// host contained in the URI, and disregards other portions of the URI
        /// such as path and port.
        ///
        /// @param aURI the URI to query for STS state.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsStsURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
	}
}