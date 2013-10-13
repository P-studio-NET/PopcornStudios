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
// Generated by IDLImporter from file nsIASN1Object.idl
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
    /// This represents an ASN.1 object,
    /// where ASN.1 is "Abstract Syntax Notation number One".
    ///
    /// The additional state information carried in this interface
    /// makes it fit for being used as the data structure
    /// when working with visual reprenstation of ASN.1 objects
    /// in a human user interface, like in a tree widget
    /// where open/close state of nodes must be remembered.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ba8bf582-1dd1-11b2-898c-f40246bc9a63")]
	public interface nsIASN1Object
	{
		
		/// <summary>
        /// "type" will be equal to one of the defined object identifiers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTypeAttribute();
		
		/// <summary>
        /// "type" will be equal to one of the defined object identifiers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute(uint aType);
		
		/// <summary>
        /// This contains a tag as explained in ASN.1 standards documents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTagAttribute();
		
		/// <summary>
        /// This contains a tag as explained in ASN.1 standards documents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTagAttribute(uint aTag);
		
		/// <summary>
        /// "displayName" contains a human readable explanatory label.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayName);
		
		/// <summary>
        /// "displayName" contains a human readable explanatory label.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayName);
		
		/// <summary>
        /// "displayValue" contains the human readable value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayValue);
		
		/// <summary>
        /// "displayValue" contains the human readable value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayValue);
	}
	
	/// <summary>nsIASN1ObjectConsts </summary>
	public class nsIASN1ObjectConsts
	{
		
		// <summary>
        // Identifiers for the possible types of object.
        // </summary>
		public const ulong ASN1_END_CONTENTS = 0;
		
		// 
		public const ulong ASN1_BOOLEAN = 1;
		
		// 
		public const ulong ASN1_INTEGER = 2;
		
		// 
		public const ulong ASN1_BIT_STRING = 3;
		
		// 
		public const ulong ASN1_OCTET_STRING = 4;
		
		// 
		public const ulong ASN1_NULL = 5;
		
		// 
		public const ulong ASN1_OBJECT_ID = 6;
		
		// 
		public const ulong ASN1_ENUMERATED = 10;
		
		// 
		public const ulong ASN1_UTF8_STRING = 12;
		
		// 
		public const ulong ASN1_SEQUENCE = 16;
		
		// 
		public const ulong ASN1_SET = 17;
		
		// 
		public const ulong ASN1_PRINTABLE_STRING = 19;
		
		// 
		public const ulong ASN1_T61_STRING = 20;
		
		// 
		public const ulong ASN1_IA5_STRING = 22;
		
		// 
		public const ulong ASN1_UTC_TIME = 23;
		
		// 
		public const ulong ASN1_GEN_TIME = 24;
		
		// 
		public const ulong ASN1_VISIBLE_STRING = 26;
		
		// 
		public const ulong ASN1_UNIVERSAL_STRING = 28;
		
		// 
		public const ulong ASN1_BMP_STRING = 30;
		
		// 
		public const ulong ASN1_HIGH_TAG_NUMBER = 31;
		
		// 
		public const ulong ASN1_CONTEXT_SPECIFIC = 32;
		
		// 
		public const ulong ASN1_APPLICATION = 33;
		
		// 
		public const ulong ASN1_PRIVATE = 34;
	}
}