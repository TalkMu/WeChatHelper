using System;

namespace WeChat.Extend.WinApi
{
    internal static class Enumerations
    {
        [Flags]
        internal enum AllocationType
        {
            Commit = 0x1000,
            Reserve = 0x2000
        }

        [Flags]
        internal enum ContextFlags
        {
            Control = 0x10001
        }

        [Flags]
        internal enum FileCharacteristics : ushort
        {
            Dll = 0x2000
        }

        [Flags]
        internal enum FreeType
        {
            Release = 0x8000
        }

        [Flags]
        internal enum MachineType : ushort
        {
            X86 = 0x14C
        }

        [Flags]
        internal enum MemoryProtection
        {
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            Guard = 0x100,
            NoCache = 0x200,
            WriteCombine = 0x400
        }

        [Flags]
        internal enum NtStatus : uint
        {
            Success = 0x00
        }

        [Flags]
        internal enum ProcessInformationClass
        {
            BasicInformation = 0x00,
            Wow64Information = 0x1A
        }

        [Flags]
        internal enum RelocationType : byte
        {
            HighLow = 0x03,
            Dir64 = 0x0A
        }

        [Flags]
        internal enum SectionCharacteristics : uint
        {
            MemoryNotCached = 0x04000000,
            MemoryExecute = 0x020000000,
            MemoryRead = 0x040000000,
            MemoryWrite = 0x080000000
        }

        [Flags]
        internal enum ThreadAccessMask
        {
            SpecificRightsAll = 0xFFFF,
            StandardRightsAll = 0x1F0000,
            AllAccess = SpecificRightsAll | StandardRightsAll
        }

        [Flags]
        internal enum VirtualKey
        {
            LeftButton = 0x01
        }

        [Flags]
        internal enum WindowsMessage
        {
            Keydown = 0x100
        }

        internal enum DesiredAccess
        {
            TOKEN_DUPLICATE = 0x0002,
            TOKEN_QUERY = 0x0008,
            TOKEN_IMPERSONATE = 0x0004,
            TOKEN_ADJUST_PRIVILEGES = 0x0020,
        }
    }
}