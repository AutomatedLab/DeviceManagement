using DeviceManagementLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace DeviceManagementModule
{
    [Cmdlet(VerbsCommon.Get, "Device", DefaultParameterSetName = "ByInstanceId")]
    [OutputType(typeof(Device))]
    public class GetDeviceCmdlet : PSCmdlet
    {
        [Parameter(Position = 1, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "ByInstanceId")]
        public string InstanceId { get; set; }

        [Parameter(Position = 1, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "ByName")]
        public string Name { get; set; }

        [Parameter(Position = 2, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        public DeviceManagementLib.Win32.DeviceClass? Class { get; set; }

        [Parameter]
        public SwitchParameter ShowNonpresentPresentDevices { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            IEnumerable<Device> devices = null;

            try
            {
                if (!string.IsNullOrEmpty(InstanceId) && @Class.HasValue)
                {
                    devices = DeviceManagementLib.DeviceManagementLib.GetDevices(InstanceId, @Class);
                }
                else if (!string.IsNullOrEmpty(InstanceId) && !@Class.HasValue)
                {
                    devices = DeviceManagementLib.DeviceManagementLib.GetDevices(InstanceId);
                }
                else if (string.IsNullOrEmpty(InstanceId) && @Class.HasValue)
                {
                    devices = DeviceManagementLib.DeviceManagementLib.GetDevices("", @Class);
                }
                else if (string.IsNullOrEmpty(InstanceId) && !@Class.HasValue)
                {
                    devices = DeviceManagementLib.DeviceManagementLib.GetDevices();
                }

                if (!ShowNonpresentPresentDevices)
                    devices = devices.Where(d => d.IsPresent);

                if (!string.IsNullOrEmpty(Name))
                    devices = devices.Where(d => d.Name == Name);

                foreach (var device in devices)
                {
                    WriteObject(device);
                }
            }
            catch (Exception ex)
            {
                WriteError(new ErrorRecord(ex, "ErrorGettingDevices", ErrorCategory.ReadError, null));
            }
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }
    }
}
