using Microsoft.Win32.SafeHandles;

namespace DeviceManagementLib.Win32
{
    internal class SafeDeviceInfoSetHandle : SafeHandleZeroOrMinusOneIsInvalid
    {

        public SafeDeviceInfoSetHandle() : base(true)
        { }

        protected override bool ReleaseHandle()
        {
            return NativeMethods.SetupDiDestroyDeviceInfoList(handle);
        }
    }
}