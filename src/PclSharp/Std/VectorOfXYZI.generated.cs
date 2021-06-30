// Code generated by a template
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Numerics;
using PclSharp.Struct;


namespace PclSharp.Std
{
	public static partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr std_vector_xyzi_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr std_vector_xyzi_ctor_count(int count);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_xyzi_delete(ref IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_xyzi_at(IntPtr ptr,  UIntPtr idx, ref PointXYZI value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern UIntPtr std_vector_xyzi_size(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_xyzi_clear(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_xyzi_resize(IntPtr ptr, int size);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_xyzi_add(IntPtr ptr, PointXYZI value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr std_vector_xyzi_data(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_xyzi_insert(IntPtr ptr, IntPtr idx, PointXYZI value);
	}

	public unsafe class VectorOfXYZI : Vector<PointXYZI>
	{	
		private bool _suppressDispose;

		public override int Count => (int)Invoke.std_vector_xyzi_size(_ptr);
		public IntPtr Data => Invoke.std_vector_xyzi_data(_ptr);
		public PointXYZI* DataU => (PointXYZI*)Data;

		public VectorOfXYZI()
		{
			_ptr = Invoke.std_vector_xyzi_ctor();
		}

		public VectorOfXYZI(int count)
		{
			_ptr = Invoke.std_vector_xyzi_ctor_count(count);
		}

		/// <summary>
        /// construct as a copy of the list
        /// </summary>
        /// <param name="list"></param>
		public VectorOfXYZI(List<PointXYZI> list)
        {
            var arr = list.ToArray();
            _ptr = Invoke.std_vector_xyzi_ctor_count(arr.Length);
            
            var dptr = (PointXYZI*)Data;
            for(var i = 0; i < arr.Length; i++)
                dptr[i] = arr[i];
        }

		internal VectorOfXYZI(IntPtr ptr)
		{
			_suppressDispose = true;
			_ptr = ptr;
		}

		public override void At(int idx, ref PointXYZI value)
		{
			Invoke.std_vector_xyzi_at(_ptr, (UIntPtr)idx, ref value);
		}

		public override PointXYZI this[int idx]
        {
            get { return DataU[idx]; }
			set { DataU[idx] = value; }
		}

		public override void Resize(int size)
			=> Invoke.std_vector_xyzi_resize(_ptr, size);

		public override void Add(PointXYZI value)
			=> Invoke.std_vector_xyzi_add(_ptr, value);

		public override void CopyTo(PointXYZI[] arr, int idx)
		{
            fixed (PointXYZI* aptr = arr)
            {
                Unsafe.CopyBlockUnaligned(aptr, DataU, (uint)(sizeof(PointXYZI) * Count));
            }
		}

		public override PointXYZI[] ToArray()
		{
			var arr = new PointXYZI[Count];
            fixed (PointXYZI* aptr = arr)
            {
                Unsafe.CopyBlockUnaligned(aptr, DataU, (uint)(sizeof(PointXYZI) * arr.Length));
            }

			return arr;
		}

		public override void Clear() => Invoke.std_vector_xyzi_clear(_ptr);

		public override void Insert(int index, PointXYZI item)
			=> Invoke.std_vector_xyzi_insert(_ptr, (IntPtr)index, item);

		public override IEnumerator<PointXYZI> GetEnumerator()
		{
			var count = Count;
			for(var i = 0; i < count; i++)
				yield return this[i];
		}

		protected override void DisposeObject()
		{
			if (_suppressDispose)
				return;
			Invoke.std_vector_xyzi_delete(ref _ptr);
		}
	}
}
