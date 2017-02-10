using System;
using System.Runtime.InteropServices;

namespace Mitsubishi_PLC_QnUCPU_In_Ethernet
{
    public static class MCSerializer
    {
        public static byte[] Serialize(object message)
        {
            int size = Marshal.SizeOf(message);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.StructureToPtr(message, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }

        public static T Deserialize<T>(byte[] bytes)
        {
            Type type = typeof(T);
            int size = Marshal.SizeOf(type);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(bytes, 0, ptr, size);

            var message = (T)Marshal.PtrToStructure(ptr, type);
            Marshal.FreeHGlobal(ptr);

            return message;
        }
    }
}