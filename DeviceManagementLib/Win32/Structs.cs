using System;
using System.Runtime.InteropServices;

namespace DeviceManagementLib.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SP_DEVINFO_DATA
    {
        public int Size;
        public Guid ClassGuid;
        public int DevInst;
        public IntPtr Reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct SP_PROPCHANGE_PARAMS
    {
        public SP_CLASSINSTALL_HEADER ClassInstallHeader;
        public DICS StateChange;
        public DICS Scope;
        public uint HwProfile;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct SP_CLASSINSTALL_HEADER
    {
        public uint cbSize;
        public DIF InstallFunction;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct SP_DRVINFO_DATA
    {
        public Int32 cbSize;
        public Int32 DriverType;
        public UIntPtr Reserved;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public String Description;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public String MfgName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public String ProviderName;

        public System.Runtime.InteropServices.ComTypes.FILETIME DriverDate;
        public Int64 DriverVersion;
    };

    [StructLayout(LayoutKind.Sequential)]
    internal struct DEVPROPKEY
    {
        public Guid fmtid;
        public uint pid;

        public DEVPROPKEY(string strGuid, uint id)
        {
            this.fmtid = new Guid(strGuid);
            this.pid = id;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct DEV_BROADCAST_DEVICEINTERFACE
    {
        public uint dbcc_size;
        public uint dbcc_devicetype;
        public uint dbcc_reserved;
        public Guid dbcc_classguid;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string dbcc_name;
    }
}