using System.Runtime.InteropServices;

namespace Mitsubishi_PLC_QnUCPU_In_Ethernet
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MCProtocol_t
    {
        [FieldOffset(0)]
        public ushort SubHeader;
        [FieldOffset(2)]
        public byte NetworkNo;
        [FieldOffset(3)]
        public byte PcNo;
        [FieldOffset(4)]
        public ushort IoNo;
        [FieldOffset(6)]
        public byte UnitNo;
        [FieldOffset(7)]
        public ushort DataLength;
        [FieldOffset(9)]
        public ushort MonitoringTimer;
        [FieldOffset(11)]
        public ushort Command;
        [FieldOffset(13)]
        public ushort SubCommand;
        [FieldOffset(15)]
        public uint DeviceNoCode;
        //[FieldOffset(18)]
        //public ushort DeviceCode;
        [FieldOffset(19)]
        public ushort DevieceNum;
    };

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct RecvMCProtocol_t
    {
        [FieldOffset(0)]
        public ushort SubHeader;
        [FieldOffset(2)]
        public byte NetworkNo;
        [FieldOffset(3)]
        public byte PcNo;
        [FieldOffset(4)]
        public ushort IoNo;
        [FieldOffset(6)]
        public byte UnitNo;
        [FieldOffset(7)]
        public ushort DataLength;
        [FieldOffset(9)]
        public ushort EndCode;
        [FieldOffset(11)]
        public byte[] ReadResult;
    };
}