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
// Generated by IDLImporter from file nsIDOMSVGMatrix.idl
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
	
	
	/// <summary>nsIDOMSVGMatrix </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ec2da3ef-5a99-49ed-aaef-b5af916c14ac")]
	public interface nsIDOMSVGMatrix
	{
		
		/// <summary>Member GetAAttribute </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetAAttribute();
		
		/// <summary>Member SetAAttribute </summary>
		/// <param name='aA'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAAttribute(float aA);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetBAttribute();
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBAttribute(float aB);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetCAttribute();
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCAttribute(float aC);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetDAttribute();
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDAttribute(float aD);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetEAttribute();
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEAttribute(float aE);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetFAttribute();
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFAttribute(float aF);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix Multiply([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGMatrix secondMatrix);
		
		/// <summary>Member Inverse </summary>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix Inverse();
		
		/// <summary>
        /// raises( SVGException );
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix Translate(float x, float y);
		
		/// <summary>Member Scale </summary>
		/// <param name='scaleFactor'> </param>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix Scale(float scaleFactor);
		
		/// <summary>Member ScaleNonUniform </summary>
		/// <param name='scaleFactorX'> </param>
		/// <param name='scaleFactorY'> </param>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix ScaleNonUniform(float scaleFactorX, float scaleFactorY);
		
		/// <summary>Member Rotate </summary>
		/// <param name='angle'> </param>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix Rotate(float angle);
		
		/// <summary>Member RotateFromVector </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix RotateFromVector(float x, float y);
		
		/// <summary>
        /// raises( SVGException );
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix FlipX();
		
		/// <summary>Member FlipY </summary>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix FlipY();
		
		/// <summary>Member SkewX </summary>
		/// <param name='angle'> </param>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix SkewX(float angle);
		
		/// <summary>Member SkewY </summary>
		/// <param name='angle'> </param>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGMatrix SkewY(float angle);
	}
}