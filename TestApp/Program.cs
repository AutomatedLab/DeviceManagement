using System.Linq;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var allDevices = DeviceManagementLib.DeviceManagementLib.GetDevices().ToList();

            //var allNetDevices = DeviceManagementLib.DeviceManagementLib.GetDevices(null, DeviceClass.GUID_DEVCLASS_NET).ToList();

            //var allCdromDevices = DeviceManagementLib.DeviceManagementLib.GetDevices(null, DeviceClass.GUID_DEVCLASS_CDROM).ToList();

            //var specifigCdromDeviceWithClass = DeviceManagementLib.DeviceManagementLib.GetDevices(@"SCSI\CDROM&VEN_HL-DT-ST&PROD_BD-RE__BH10LS38\4&19BF6B6&0&030000", DeviceClass.GUID_DEVCLASS_CDROM).ToList();
            //var specifigProcNoClass = DeviceManagementLib.DeviceManagementLib.GetDevices(@"ACPI\GENUINEINTEL_-_INTEL64_FAMILY_6_MODEL_45_-________INTEL(R)_CORE(TM)_I7-3930K_CPU_@_3.20GHZ\_1", DeviceClass.GUID_DEVCLASS_PROCESSOR).ToList();

            //DeviceManagementLib.DeviceManagementLib.RemoveDevice(@"SCSI\CDROM&VEN_MSFT&PROD_VIRTUAL_DVD-ROM\2&1F4ADFFE&0&000007");

            

            var net1 = DeviceManagementLib.DeviceManagementLib.GetDevices(@"ROOT\SDHOST\0000").FirstOrDefault();
            var ready1 = net1.IsPresent;
            var man1 = net1.Manufacturer;
            var p1 = net1.HasProblem;
            var lp1 = net1.LocationPaths;
            var li1 = net1.LocationInfo;

            var net2 = DeviceManagementLib.DeviceManagementLib.GetDevices(@"VMBUS\{D66AB3C2-37ED-4F0C-8E9C-B4717C71A8D8}\5&296C0F0E&0&{D66AB3C2-37ED-4F0C-8E9C-B4717C71A8D8}").FirstOrDefault();
            var ready2 = net2.IsPresent;

            DeviceManagementLib.DeviceManagementLib.RemoveDevice(net2.InstanceId);

            var x = DeviceManagementLib.DeviceManagementLib.GetDevices(@"SCSI\DISK&VEN_MSFT&PROD_VIRTUAL_DISK\2&1F4ADFFE&0&000002", DeviceManagementLib.Win32.DeviceClass.GUID_DEVCLASS_DISKDRIVE).ToList().FirstOrDefault();
            System.Console.WriteLine(x.ConfigurationFlags);
            //DeviceManagementLib.DeviceManagementLib.SetDeviceState(@"PCI\VEN_8086&DEV_1503&SUBSYS_849C1043&REV_05\3&11583659&0&C8", DICS.DICS_DISABLE);

            //DeviceManagementLib.DeviceManagementLib.RemoveDevice(@"USB\VID_0CCD&PID_0038\7&25769D8B&0&2");
        }
    }
}