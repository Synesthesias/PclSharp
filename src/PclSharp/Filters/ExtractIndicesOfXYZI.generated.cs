// Code generated by a template
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using PclSharp.Struct;
using PclSharp.Std;
namespace PclSharp.Filters
{
	public static partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr filters_extractIndices_xyzi_ctor([MarshalAs(UnmanagedType.I1)]bool extractRemovedIndices);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_extractIndices_xyzi_delete(ref IntPtr ptr);
		//methods
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_extractIndices_xyzi_filter(IntPtr ptr, IntPtr output);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_extractIndices_xyzi_setInputCloud(IntPtr ptr, IntPtr cloud);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_extractIndices_xyzi_setIndices(IntPtr ptr, IntPtr indices);

		//properties
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_extractIndices_xyzi_setKeepOrganized(IntPtr ptr, bool value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool filters_extractIndices_xyzi_getKeepOrganized(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void filters_extractIndices_xyzi_setNegative(IntPtr ptr, bool value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool filters_extractIndices_xyzi_getNegative(IntPtr ptr);
	}

	public class ExtractIndicesOfXYZI : ExtractIndices<PointXYZI>
	{
		public override bool Negative
		{
			get { return Invoke.filters_extractIndices_xyzi_getNegative(_ptr); }
            set { Invoke.filters_extractIndices_xyzi_setNegative(_ptr, value); }
		}

		public override bool KeepOrganized
		{
			get { return Invoke.filters_extractIndices_xyzi_getKeepOrganized(_ptr); }
            set { Invoke.filters_extractIndices_xyzi_setKeepOrganized(_ptr, value); }
		}

		public ExtractIndicesOfXYZI(bool extractRemovedIndices = false)
		{
			_ptr = Invoke.filters_extractIndices_xyzi_ctor(extractRemovedIndices);
		}

		public override void SetInputCloud(PointCloud<PointXYZI> cloud)
		{
			Invoke.filters_extractIndices_xyzi_setInputCloud(_ptr, cloud);
		}

		public override void filter(PointCloud<PointXYZI> output)
		{
			Invoke.filters_extractIndices_xyzi_filter(_ptr, output.Ptr);
		}

		public override void SetIndices(VectorOfInt indices)
		{
			Invoke.filters_extractIndices_xyzi_setIndices(_ptr, indices);
		}

		public override ref PointXYZI this[int idx]
		{
			get { return ref this.Index(idx); }
		}

		protected override void DisposeObject()
		{
			Invoke.filters_extractIndices_xyzi_delete(ref _ptr);
		}
	}
}
