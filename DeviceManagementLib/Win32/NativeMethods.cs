using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DeviceManagementLib.Win32
{
    internal static class NativeMethods
    {
        private const string setupapi = "setupapi.dll";
        private const string newdevapi = "newdev.dll";

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiCallClassInstaller(
            DIF InstallFunction,
            SafeDeviceInfoSetHandle DeviceInfoSet,
            ref SP_DEVINFO_DATA DeviceInfoData);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiEnumDeviceInfo(
            SafeDeviceInfoSetHandle DeviceInfoSet,
            int MemberIndex,
            ref SP_DEVINFO_DATA DeviceInfoData);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern SafeDeviceInfoSetHandle SetupDiGetClassDevs(
            IntPtr guid,
            [MarshalAs(UnmanagedType.LPWStr)]
            string enumerator,
            IntPtr hwndParent,
            SetupDiGetClassDevsFlags flags);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiGetDeviceInstanceId(
            IntPtr DeviceInfoSet,
            ref SP_DEVINFO_DATA did,
            [MarshalAs(UnmanagedType.LPTStr)]
            StringBuilder DeviceInstanceId,
            int DeviceInstanceIdSize,
            out int RequiredSize);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiDestroyDeviceInfoList(
            IntPtr deviceInfoSet);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiSetClassInstallParams(
            SafeDeviceInfoSetHandle deviceInfoSet,
            ref SP_DEVINFO_DATA deviceInfoData,
            ref SP_PROPCHANGE_PARAMS classInstallParams,
            uint classInstallParamsSize);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DiInstallDevice(
           IntPtr hParent,
           IntPtr lpInfoSet,
           SP_DEVINFO_DATA DeviceInfoData,
           SP_DRVINFO_DATA DriverInfoData,
           UInt32 Flags,
           [MarshalAs(UnmanagedType.Bool)] ref bool NeedReboot);

        [DllImport(newdevapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DiUninstallDevice(
            IntPtr hwndParent,
            IntPtr DeviceInfoSet,
            ref SP_DEVINFO_DATA DeviceInfoData,
            uint Flags,
            out bool pbNeedReboot);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern SafeDeviceInfoSetHandle SetupDiCreateDeviceInfoList(
            IntPtr ClassGuid,
            IntPtr hwndParent);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiGetINFClass(
            string infName,
            ref Guid ClassGuid,
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder ClassName,
            int ClassNameSize,
            int RequiredSize);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetupDiGetDevicePropertyKeys(
            SafeDeviceInfoSetHandle DeviceInfoSet,
            ref SP_DEVINFO_DATA DeviceInfoData,
            IntPtr PropertyKeyArray,
            uint PropertyKeyCount,
            ref uint RequiredPropertyKeyCount,
            uint Flags);

        [DllImport(setupapi, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetupDiGetDeviceProperty(
            SafeDeviceInfoSetHandle DeviceInfoSet,
            ref SP_DEVINFO_DATA DeviceInfoData,
            ref DEVPROPKEY PropertyKey,
            out DEVPROPTYPE PropertyType,
            byte[] PropertyBuffer,
            uint PropertyBufferSize,
            ref uint RequiredSize,
            uint Flags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr RegisterDeviceNotification(
            IntPtr hRecipient,
            DEV_BROADCAST_DEVICEINTERFACE NotificationFilter,
            DEVICE_NOTIFY Flags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern uint UnregisterDeviceNotification(
            IntPtr hHandle);
    }
}