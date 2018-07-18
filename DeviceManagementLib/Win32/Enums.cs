using System;

namespace DeviceManagementLib.Win32
{
    [Flags]
    public enum SetupDiGetClassDevsFlags
    {
        Null = 0,
        Default = 1,
        Present = 2,
        AllClasses = 4,
        Profile = 8,
        DeviceInterface = 16
    }

    public enum DIF : uint
    {
        DIF_SELECTDEVICE = 0x1,
        DIF_INSTALLDEVICE = 0x2,
        DIF_ASSIGNRESOURCES = 0x3,
        DIF_PROPERTIES = 0x4,
        DIF_REMOVE = 0x5,
        DIF_FIRSTTIMESETUP = 0x6,
        DIF_FOUNDDEVICE = 0x7,
        DIF_SELECTCLASSDRIVERS = 0x8,
        DIF_VALIDATECLASSDRIVERS = 0x9,
        DIF_INSTALLCLASSDRIVERS = 0xA,
        DIF_CALCDISKSPACE = 0xB,
        DIF_DESTROYPRIVATEDATA = 0xC,
        DIF_VALIDATEDRIVER = 0xD,
        DIF_MOVEDEVICE = 0xE,
        DIF_DETECT = 0xF,
        DIF_INSTALLWIZARD = 0x10,
        DIF_DESTROYWIZARDDATA = 0x11,
        DIF_PROPERTYCHANGE = 0x12,
        DIF_ENABLECLASS = 0x13,
        DIF_DETECTVERIFY = 0x14,
        DIF_INSTALLDEVICEFILES = 0x15,
        DIF_UNREMOVE = 0x16,
        DIF_SELECTBESTCOMPATDRV = 0x17,
        DIF_ALLOW_INSTALL = 0x18,
        DIF_REGISTERDEVICE = 0x19,
        DIF_NEWDEVICEWIZARD_PRESELECT = 0x1A,
        DIF_NEWDEVICEWIZARD_SELECT = 0x1B,
        DIF_NEWDEVICEWIZARD_PREANALYZE = 0x1C,
        DIF_NEWDEVICEWIZARD_POSTANALYZE = 0x1D,
        DIF_NEWDEVICEWIZARD_FINISHINSTALL = 0x1E,
        DIF_UNUSED1 = 0x1F,
        DIF_INSTALLINTERFACES = 0x20,
        DIF_DETECTCANCEL = 0x21,
        DIF_REGISTER_COINSTALLERS = 0x22,
        DIF_ADDPROPERTYPAGE_ADVANCED = 0x23,
        DIF_ADDPROPERTYPAGE_BASIC = 0x24,
        DIF_RESERVED1 = 0x25,
        DIF_TROUBLESHOOTER = 0x26,
        DIF_POWERMESSAGEWAKE = 0x27
    }

    public enum DICS
    {
        DICS_ENABLE = 0x1,
        DICS_DISABLE = 0x2,
        DICS_PROPCHANGE = 0x3,
        DICS_START = 0x4,
        DICS_STOP = 0x5,
        DICS_FLAG_GLOBAL = DICS_ENABLE,
        DICS_FLAG_CONFIGSPECIFIC = DICS_DISABLE,
        DICS_FLAG_CONFIGGENERAL = DICS_START
    }

    internal enum SetupApiError
    {
        NoAssociatedClass = unchecked((int)0xe0000200),
        ClassMismatch = unchecked((int)0xe0000201),
        DuplicateFound = unchecked((int)0xe0000202),
        NoDriverSelected = unchecked((int)0xe0000203),
        KeyDoesNotExist = unchecked((int)0xe0000204),
        InvalidDevinstName = unchecked((int)0xe0000205),
        InvalidClass = unchecked((int)0xe0000206),
        DevinstAlreadyExists = unchecked((int)0xe0000207),
        DevinfoNotRegistered = unchecked((int)0xe0000208),
        InvalidRegProperty = unchecked((int)0xe0000209),
        NoInf = unchecked((int)0xe000020a),
        NoSuchHDevinst = unchecked((int)0xe000020b),
        CantLoadClassIcon = unchecked((int)0xe000020c),
        InvalidClassInstaller = unchecked((int)0xe000020d),
        DiDoDefault = unchecked((int)0xe000020e),
        DiNoFileCopy = unchecked((int)0xe000020f),
        InvalidHwProfile = unchecked((int)0xe0000210),
        NoDeviceSelected = unchecked((int)0xe0000211),
        DevinfolistLocked = unchecked((int)0xe0000212),
        DevinfodataLocked = unchecked((int)0xe0000213),
        DiBadPath = unchecked((int)0xe0000214),
        NoClassInstallParams = unchecked((int)0xe0000215),
        FileQueueLocked = unchecked((int)0xe0000216),
        BadServiceInstallSect = unchecked((int)0xe0000217),
        NoClassDriverList = unchecked((int)0xe0000218),
        NoAssociatedService = unchecked((int)0xe0000219),
        NoDefaultDeviceInterface = unchecked((int)0xe000021a),
        DeviceInterfaceActive = unchecked((int)0xe000021b),
        DeviceInterfaceRemoved = unchecked((int)0xe000021c),
        BadInterfaceInstallSect = unchecked((int)0xe000021d),
        NoSuchInterfaceClass = unchecked((int)0xe000021e),
        InvalidReferenceString = unchecked((int)0xe000021f),
        InvalidMachineName = unchecked((int)0xe0000220),
        RemoteCommFailure = unchecked((int)0xe0000221),
        MachineUnavailable = unchecked((int)0xe0000222),
        NoConfigMgrServices = unchecked((int)0xe0000223),
        InvalidPropPageProvider = unchecked((int)0xe0000224),
        NoSuchDeviceInterface = unchecked((int)0xe0000225),
        DiPostProcessingRequired = unchecked((int)0xe0000226),
        InvalidCOInstaller = unchecked((int)0xe0000227),
        NoCompatDrivers = unchecked((int)0xe0000228),
        NoDeviceIcon = unchecked((int)0xe0000229),
        InvalidInfLogConfig = unchecked((int)0xe000022a),
        DiDontInstall = unchecked((int)0xe000022b),
        InvalidFilterDriver = unchecked((int)0xe000022c),
        NonWindowsNTDriver = unchecked((int)0xe000022d),
        NonWindowsDriver = unchecked((int)0xe000022e),
        NoCatalogForOemInf = unchecked((int)0xe000022f),
        DevInstallQueueNonNative = unchecked((int)0xe0000230),
        NotDisableable = unchecked((int)0xe0000231),
        CantRemoveDevinst = unchecked((int)0xe0000232),
        InvalidTarget = unchecked((int)0xe0000233),
        DriverNonNative = unchecked((int)0xe0000234),
        InWow64 = unchecked((int)0xe0000235),
        SetSystemRestorePoint = unchecked((int)0xe0000236),
        IncorrectlyCopiedInf = unchecked((int)0xe0000237),
        SceDisabled = unchecked((int)0xe0000238),
        UnknownException = unchecked((int)0xe0000239),
        PnpRegistryError = unchecked((int)0xe000023a),
        RemoteRequestUnsupported = unchecked((int)0xe000023b),
        NotAnInstalledOemInf = unchecked((int)0xe000023c),
        InfInUseByDevices = unchecked((int)0xe000023d),
        DiFunctionObsolete = unchecked((int)0xe000023e),
        NoAuthenticodeCatalog = unchecked((int)0xe000023f),
        AuthenticodeDisallowed = unchecked((int)0xe0000240),
        AuthenticodeTrustedPublisher = unchecked((int)0xe0000241),
        AuthenticodeTrustNotEstablished = unchecked((int)0xe0000242),
        AuthenticodePublisherNotTrusted = unchecked((int)0xe0000243),
        SignatureOSAttributeMismatch = unchecked((int)0xe0000244),
        OnlyValidateViaAuthenticode = unchecked((int)0xe0000245)
    }

    [Flags]
    public enum DeviceCapabilities : uint
    {
        CM_DEVCAP_LOCKSUPPORTED = 1,
        CM_DEVCAP_EJECTSUPPORTED = 2,
        CM_DEVCAP_REMOVABLE = 4,
        CM_DEVCAP_DOCKDEVICE = 8,
        CM_DEVCAP_UNIQUEID = 16,
        CM_DEVCAP_SILENTINSTALL = 32,
        CM_DEVCAP_RAWDEVICEOK = 64,
        CM_DEVCAP_SURPRISEREMOVALOK = 128,
        CM_DEVCAP_HARDWAREDISABLED = 256,
        CM_DEVCAP_NONDYNAMIC = 512
    }

    public enum DeviceCharacteristics : uint
    {
        FILE_REMOVABLE_MEDIA = 1,
        FILE_READ_ONLY_DEVICE,
        FILE_FLOPPY_DISKETTE = 4,
        FILE_WRITE_ONCE_MEDIA = 8,
        FILE_REMOTE_DEVICE = 16,
        FILE_DEVICE_IS_MOUNTED = 32,
        FILE_VIRTUAL_VOLUME = 64,
        FILE_AUTOGENERATED_DEVICE_NAME = 128,
        FILE_DEVICE_SECURE_OPEN = 256,
        FILE_CHARACTERISTIC_PNP_DEVICE = 2048,
        FILE_CHARACTERISTIC_TS_DEVICE = 4096,
        FILE_CHARACTERISTIC_WEBDAV_DEVICE = 8192
    }

    [Flags]
    public enum DeviceConfigurationFlags : uint
    {
        CONFIGFLAG_DISABLED = 1,
        CONFIGFLAG_REMOVED = 2,
        CONFIGFLAG_MANUAL_INSTALL = 4,
        CONFIGFLAG_IGNORE_BOOT_LC = 8,
        CONFIGFLAG_NET_BOOT = 16,
        CONFIGFLAG_REINSTALL = 32,
        CONFIGFLAG_FAILEDINSTALL = 64,
        CONFIGFLAG_CANTSTOPACHILD = 128,
        CONFIGFLAG_OKREMOVEROM = 256,
        CONFIGFLAG_NOREMOVEEXIT = 512,
        CONFIGFLAG_FINISH_INSTALL = 1024,
        CONFIGFLAG_NEEDS_FORCED_CONFIG = 2048,
        CONFIGFLAG_NETBOOT_CARD = 4096,
        CONFIGFLAG_PARTIAL_LOG_CONF = 8192,
        CONFIGFLAG_SUPPRESS_SURPRISE = 16384,
        CONFIGFLAG_VERIFY_HARDWARE = 32768,
        CONFIGFLAG_FINISHINSTALL_UI = 65536,
        CONFIGFLAG_FINISHINSTALL_ACTION = 131072,
        CONFIGFLAG_BOOT_DEVICE = 262144,
        CSCONFIGFLAG_BITS = 7,
        CSCONFIGFLAG_DISABLED = 1,
        CSCONFIGFLAG_DO_NOT_CREATE = 2,
        CSCONFIGFLAG_DO_NOT_START = 4
    }

    public enum DeviceInstallState : uint
    {
        InstallStateInstalled,
        InstallStateNeedsReinstall,
        InstallStateFailedInstall,
        InstallStateFinishInstall
    }

    [Flags]
    internal enum DEVPROPTYPE : uint
    {
        DEVPROP_TYPEMOD_ARRAY = 4096,
        DEVPROP_TYPEMOD_LIST = 8192,
        DEVPROP_TYPE_EMPTY = 0,
        DEVPROP_TYPE_NULL = 1,
        DEVPROP_TYPE_SBYTE = 2,
        DEVPROP_TYPE_BYTE = 3,
        DEVPROP_TYPE_INT16 = 4,
        DEVPROP_TYPE_UINT16 = 5,
        DEVPROP_TYPE_INT32 = 6,
        DEVPROP_TYPE_UINT32 = 7,
        DEVPROP_TYPE_INT64 = 8,
        DEVPROP_TYPE_UINT64 = 9,
        DEVPROP_TYPE_FLOAT = 10,
        DEVPROP_TYPE_DOUBLE = 11,
        DEVPROP_TYPE_DECIMAL = 12,
        DEVPROP_TYPE_GUID = 13,
        DEVPROP_TYPE_CURRENCY = 14,
        DEVPROP_TYPE_DATE = 15,
        DEVPROP_TYPE_FILETIME = 16,
        DEVPROP_TYPE_BOOLEAN = 17,
        DEVPROP_TYPE_STRING = 18,
        DEVPROP_TYPE_SECURITY_DESCRIPTOR = 19,
        DEVPROP_TYPE_SECURITY_DESCRIPTOR_STRING = 20,
        DEVPROP_TYPE_DEVPROPKEY = 21,
        DEVPROP_TYPE_DEVPROPTYPE = 22,
        DEVPROP_TYPE_ERROR = 23,
        DEVPROP_TYPE_NTSTATUS = 24,
        DEVPROP_TYPE_STRING_INDIRECT = 25,
        DEVPROP_TYPE_BINARY = 4099,
        DEVPROP_TYPE_STRING_LIST = 8210
    }

    /// <summary>
    /// Device registry property codes
    /// (Codes marked as read-only (R) may only be used for SetupDiGetDeviceRegistryProperty)
    /// These values should cover the same set of registry properties
    /// </summary>
    public enum SPDRP
    {
        SPDRP_DEVICEDESC = 0,
        SPDRP_HARDWAREID = 0x1,
        SPDRP_COMPATIBLEIDS = 0x2,
        SPDRP_UNUSED0 = 0x3,
        SPDRP_SERVICE = 0x4,
        SPDRP_UNUSED1 = 0x5,
        SPDRP_UNUSED2 = 0x6,
        SPDRP_CLASS = 0x7,
        SPDRP_CLASSGUID = 0x8,
        SPDRP_DRIVER = 0x9,
        SPDRP_CONFIGFLAGS = 0xA,
        SPDRP_MFG = 0xB,
        SPDRP_FRIENDLYNAME = 0xC,
        SPDRP_LOCATION_INFORMATION = 0xD,
        SPDRP_PHYSICAL_DEVICE_OBJECT_NAME = 0xE,
        SPDRP_CAPABILITIES = 0xF,
        SPDRP_UI_NUMBER = 0x10,
        SPDRP_UPPERFILTERS = 0x11,
        SPDRP_LOWERFILTERS = 0x12,
        SPDRP_BUSTYPEGUID = 0x13,
        SPDRP_LEGACYBUSTYPE = 0x14,
        SPDRP_BUSNUMBER = 0x15,
        SPDRP_ENUMERATOR_NAME = 0x16,
        SPDRP_SECURITY = 0x17,
        SPDRP_SECURITY_SDS = 0x18,
        SPDRP_DEVTYPE = 0x19,
        SPDRP_EXCLUSIVE = 0x1A,
        SPDRP_CHARACTERISTICS = 0x1B,
        SPDRP_ADDRESS = 0x1C,
        SPDRP_UI_NUMBER_DESC_FORMAT = 0x1E,
        SPDRP_MAXIMUM_PROPERTY = 0x1F
    }

    public enum DeviceClass : uint
    {
        GUID_DEVCLASS_1394,
        GUID_DEVCLASS_1394DEBUG,
        GUID_DEVCLASS_61883,
        GUID_DEVCLASS_ADAPTER,
        GUID_DEVCLASS_APMSUPPORT,
        GUID_DEVCLASS_AVC,
        GUID_DEVCLASS_BATTERY,
        GUID_DEVCLASS_BIOMETRIC,
        GUID_DEVCLASS_BLUETOOTH,
        GUID_DEVCLASS_CDROM,
        GUID_DEVCLASS_COMPUTER,
        GUID_DEVCLASS_DECODER,
        GUID_DEVCLASS_DISKDRIVE,
        GUID_DEVCLASS_DISPLAY,
        GUID_DEVCLASS_DOT4,
        GUID_DEVCLASS_DOT4PRINT,
        GUID_DEVCLASS_ENUM1394,
        GUID_DEVCLASS_FDC,
        GUID_DEVCLASS_FLOPPYDISK,
        GUID_DEVCLASS_GPS,
        GUID_DEVCLASS_HDC,
        GUID_DEVCLASS_HIDCLASS,
        GUID_DEVCLASS_IMAGE,
        GUID_DEVCLASS_INFINIBAND,
        GUID_DEVCLASS_INFRARED,
        GUID_DEVCLASS_KEYBOARD,
        GUID_DEVCLASS_LEGACYDRIVER,
        GUID_DEVCLASS_MEDIA,
        GUID_DEVCLASS_MEDIUM_CHANGER,
        GUID_DEVCLASS_MEMORY,
        GUID_DEVCLASS_MODEM,
        GUID_DEVCLASS_MONITOR,
        GUID_DEVCLASS_MOUSE,
        GUID_DEVCLASS_MTD,
        GUID_DEVCLASS_MULTIFUNCTION,
        GUID_DEVCLASS_MULTIPORTSERIAL,
        GUID_DEVCLASS_NET,
        GUID_DEVCLASS_NETCLIENT,
        GUID_DEVCLASS_NETSERVICE,
        GUID_DEVCLASS_NETTRANS,
        GUID_DEVCLASS_NODRIVER,
        GUID_DEVCLASS_PCMCIA,
        GUID_DEVCLASS_PNPPRINTERS,
        GUID_DEVCLASS_PORTS,
        GUID_DEVCLASS_PRINTER,
        GUID_DEVCLASS_PRINTERUPGRADE,
        GUID_DEVCLASS_PROCESSOR,
        GUID_DEVCLASS_SBP2,
        GUID_DEVCLASS_SCSIADAPTER,
        GUID_DEVCLASS_SECURITYACCELERATOR,
        GUID_DEVCLASS_SENSOR,
        GUID_DEVCLASS_SIDESHOW,
        GUID_DEVCLASS_SMARTCARDREADER,
        GUID_DEVCLASS_SOUND,
        GUID_DEVCLASS_SYSTEM,
        GUID_DEVCLASS_TAPEDRIVE,
        GUID_DEVCLASS_UNKNOWN,
        GUID_DEVCLASS_USB,
        GUID_DEVCLASS_VOLUME,
        GUID_DEVCLASS_VOLUMESNAPSHOT,
        GUID_DEVCLASS_WCEUSBS,
        GUID_DEVCLASS_WPD,
        GUID_DEVCLASS_EHSTORAGESILO
    }

    public enum DBT_DEVTYP : uint
    {
        DBT_DEVTYP_OEM = 0,
        DBT_DEVTYP_DEVNODE = 1,
        DBT_DEVTYP_VOLUME = 2,
        DBT_DEVTYP_PORT = 3,
        DBT_DEVTYP_NET = 4,
        DBT_DEVTYP_DEVICEINTERFACE = 5,
        DBT_DEVTYP_HANDLE = 6
    }

    [Flags]
    public enum DEVICE_NOTIFY
    {
        DEVICE_NOTIFY_WINDOW_HANDLE = 0x0,
        DEVICE_NOTIFY_SERVICE_HANDLE = 0x1,
        DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 0x4
    }

    /// <summary>
    /// Best documentation found: http://caveprojects.org/packages/cave-library/Docs/html/T_System_Native_Windows_DN.htm
    /// </summary>
    public enum DNFlags : uint
    {
        ROOT_ENUMERATED = 1,
        DRIVER_LOADED = 2,
        ENUM_LOADED = 4,
        STARTED = 8,
        MANUAL = 16,
        NEED_TO_ENUM = 32,
        NOT_FIRST_TIME = 64,
        HARDWARE_ENUM = 128,
        LIAR = 256,
        HAS_MASK = 512,
        HAS_PROBLEM = 1024,
        FILTERED = 2048,
        MOVED = 4096,
        DISABLEABLE = 8192,
        REMOVABLE = 16384,
        PRIVATE_PROBLEM = 32768,
        MF_PARENT = 65536,
        MF_CHILD = 131072,
        WILL_BE_REMOVED = 262144,
        NOT_FIRST_TIMEE = 524288,
        STOP_FREE_RES = 1048576,
        REBAL_CANDIDATE = 2097152,
        BAD_PARTIAL = 4194304,
        NT_ENUMERATOR = 8388608,
        NT_DRIVER = 16777216,
        NEEDS_LOCKING = 33554432,
        ARM_WAKEUP = 67108864,
        APM_ENUMERATOR = 134217728,
        APM_DRIVER = 268435456,
        SILENT_INSTALL = 536870912,
        NO_SHOW_IN_DM = 1073741824,
        BOOT_LOG_PROB = 2147483648
    }

    /// <summary>
    /// Best documentation found: http://caveprojects.org/packages/cave-library/Docs/html/T_System_Native_Windows_CM_PROB.htm
    /// </summary>
    [Flags]
    public enum CM_PROB
    {
        NOT_CONFIGURED = 1,
        DEVLOADER_FAILED = 2,
        OUT_OF_MEMORY = 3,
        ENTRY_IS_WRONG_TYPE = 4,
        LACKED_ARBITRATOR = 5,
        BOOT_CONFIG_CONFLICT = 6,
        FAILED_FILTER = 7,
        DEVLOADER_NOT_FOUND = 8,
        INVALID_DATA = 9,
        FAILED_START = 10,
        LIAR = 11,
        NORMAL_CONFLICT = 12,
        NOT_VERIFIED = 13,
        NEED_RESTART = 14,
        REENUMERATION = 15,
        PARTIAL_LOG_CONF = 16,
        UNKNOWN_RESOURCE = 17,
        REINSTALL = 18,
        REGISTRY = 19,
        VXDLDR = 20,
        WILL_BE_REMOVED = 21,
        DISABLED = 22,
        DEVLOADER_NOT_READY = 23,
        DEVICE_NOT_THERE = 24,
        MOVED = 25,
        TOO_EARLY = 26,
        NO_VALID_LOG_CONF = 27,
        FAILED_INSTALL = 28,
        HARDWARE_DISABLED = 29,
        CANT_SHARE_IRQ = 30,
        FAILED_ADD = 31,
        DISABLED_SERVICE = 32,
        TRANSLATION_FAILED = 33,
        NO_SOFTCONFIG = 34,
        BIOS_TABLE = 35,
        IRQ_TRANSLATION_FAILED = 36,
        FAILED_DRIVER_ENTRY = 37,
        DRIVER_FAILED_PRIOR_UNLOAD = 38,
        DRIVER_FAILED_LOAD = 39,
        DRIVER_SERVICE_KEY_INVALID = 40,
        LEGACY_SERVICE_NO_DEVICES = 41,
        DUPLICATE_DEVICE = 42,
        FAILED_POST_START = 43,
        HALTED = 44,
        PHANTOM = 45,
        SYSTEM_SHUTDOWN = 46,
        HELD_FOR_EJECT = 47,
        DRIVER_BLOCKED = 48,
        REGISTRY_TOO_LARGE = 49,
        SETPROPERTIES_FAILED = 50,
        WAITING_ON_DEPENDENCY = 51,
        UNSIGNED_DRIVER = 52
    }
}