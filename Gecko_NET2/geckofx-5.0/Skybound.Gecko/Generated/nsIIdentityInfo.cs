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
// Generated by IDLImporter from file nsIIdentityInfo.idl
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
	
	
	/// <summary>nsIIdentityInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e9da87b8-b87c-4bd1-a6bc-5a9a2c7f6d8d")]
	public interface nsIIdentityInfo
	{
		
		/// <summary>
        /// A "true" value means:
        /// The object that implements this interface uses a certificate that
        /// was successfully verified as an Extended Validation (EV) cert.
        /// The test is bound to SSL Server Cert Usage.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsExtendedValidationAttribute();
		
		/// <summary>
        /// This function uses the same test as attribute
        /// isExtendedValidation
        ///
        /// If isExtendedValidation is true, this function will return
        /// a policy identifier in dotted notation (like 1.2.3.4.5).
        ///
        /// If isExtendedValidation is false, this function will return
        /// an empty (length string) value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValidEVPolicyOid([MarshalAs(UnmanagedType.LPStruct)] nsACString retval);
	}
}