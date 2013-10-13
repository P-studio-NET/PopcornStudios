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
// Generated by IDLImporter from file nsIDocumentLoaderFactory.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// To get a component that implements nsIDocumentLoaderFactory
    /// for a given mimetype, use nsICategoryManager to find an entry
    /// with the mimetype as its name in the category "Gecko-Content-Viewers".
    /// The value of the entry is the contractid of the component.
    /// The component is a service, so use GetService, not CreateInstance to get it.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5e7d2967-5a07-444f-95d5-25b533252d38")]
	public interface nsIDocumentLoaderFactory
	{
		
		/// <summary>
        /// To get a component that implements nsIDocumentLoaderFactory
        /// for a given mimetype, use nsICategoryManager to find an entry
        /// with the mimetype as its name in the category "Gecko-Content-Viewers".
        /// The value of the entry is the contractid of the component.
        /// The component is a service, so use GetService, not CreateInstance to get it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CreateInstance([MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup, [MarshalAs(UnmanagedType.LPStr)] string aContentType, [MarshalAs(UnmanagedType.Interface)] nsISupports aContainer, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtraInfo, [MarshalAs(UnmanagedType.Interface)] ref nsIStreamListener aDocListenerResult);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CreateInstanceForDocument([MarshalAs(UnmanagedType.Interface)] nsISupports aContainer, System.IntPtr aDocument, [MarshalAs(UnmanagedType.LPStr)] string aCommand);
		
		/// <summary>
        /// Create a blank document using the given loadgroup and given
        /// principal.  aPrincipal is allowed to be null, in which case the
        /// new document will get the about:blank codebase principal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CreateBlankDocument([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
	}
}