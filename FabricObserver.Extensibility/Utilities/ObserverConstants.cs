﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace FabricObserver.Observers.Utilities
{
    public sealed class ObserverConstants
    {
        // ObserverManager settings.
        public const string ObserverManagerName = "ObserverManager";
        public const string ObserverManagerConfigurationSectionName = "ObserverManagerConfiguration";
        public const string EnableCSVDataLogging = "EnableCSVDataLogging";
        public const string EnableETWProvider = "EnableETWProvider";
        public const string ETWProviderName = "ETWProviderName";
        public const string DefaultEventSourceProviderName = "FabricObserverETWProvider";
        public const string FabricObserverETWEventName = "FabricObserverDataEvent";
        public const string EnableFabricObserverOperationalTelemetry = "EnableFabricObserverOperationalTelemetry";
        public const string AsyncClusterOperationTimeoutSeconds = "ClusterOperationTimeoutSeconds";
        public const string ObserverFailureHealthStateLevelParameter = "ObserverFailureHealthStateLevel";
        public const string CheckGithubVersion = "CheckGithubVersion";

        // The name of the package that contains this Observer's configuration
        public const string ObserverConfigurationPackageName = "Config";

        // Setting name for Runtime frequency of the Observer
        public const string ObserverLoopSleepTimeSeconds = "ObserverLoopSleepTimeSeconds";

        // Default to 1 minute if frequency is not supplied in config
        public const int ObserverRunLoopSleepTimeSeconds = 60;

        public const string AllObserversExecutedMessage = "All Observers have been executed.";

        // Setting name for Grace period of shutdown in seconds.
        public const string ObserverShutdownGracePeriodInSeconds = "ObserverShutdownGracePeriodInSeconds";

        // Setting name for Maximum time an observer should run before being considered hung or in some failure state.
        public const string ObserverExecutionTimeout = "ObserverExecutionTimeout";

        public const string FabricObserverName = "FabricObserver";

        // Common Observer Settings Parameters.
        public const string ObserverLogPathParameter = "ObserverLogPath";
        public const string DataLogPathParameter = "DataLogPath";
        public const string ObserverRunIntervalParameter = "RunInterval";
        public const string ObserverEnabledParameter = "Enabled";
        public const string ObserverTelemetryEnabledParameter = "EnableTelemetry";
        public const string ObserverEtwEnabledParameter = "EnableEtw";
        public const string EnableVerboseLoggingParameter = "EnableVerboseLogging";
        public const string DataCapacityParameter = "ResourceUsageDataCapacity";
        public const string UseCircularBufferParameter = "UseCircularBuffer";
        public const string MonitorDurationParameter = "MonitorDuration";
        public const string MonitorSleepDurationParameter = "MonitorSleepDurationMilliseconds";
        public const string MaxArchivedCsvFileLifetimeDaysParameter = "MaxArchivedCsvFileLifetimeDays";
        public const string MaxArchivedLogFileLifetimeDaysParameter = "MaxArchivedLogFileLifetimeDays";
        public const string CsvFileWriteFormatParameter = "CsvFileWriteFormat";
        public const string EnableConcurrentMonitoringParameter = "EnableConcurrentMonitoring";
        public const string MaxConcurrentTasksParameter = "MaxConcurrentTasks";
        public const string EnableKvsLvidMonitoringParameter = "EnableKvsLvidMonitoring";
        public const string MonitorPrivateWorkingSetParameter = "MonitorPrivateWorkingSet";
        public const string ConfigurationFileNameParameter = "ConfigurationFileName";
        public const string ProcessDumpFolderNameParameter = "MemoryDumps";

        // AppObserver.
        public const string AppObserverName = "AppObserver";
        public const string AppObserverDataFileName = "AppObserverDataFileName";
        public const string AppObserverConfigurationSectionName = "AppObserverConfiguration";
        public const string EnableChildProcessMonitoringParameter = "EnableChildProcessMonitoring";
        public const string MaxChildProcTelemetryDataCountParameter = "MaxChildProcTelemetryDataCount";
        public const string EnableProcessDumpsParameter = "EnableProcessDumps";
        public const string DumpTypeParameter = "DumpType";
        public const string MaxDumpsParameter = "MaxDumps";
        public const string MaxDumpsTimeWindowParameter = "MaxDumpsTimeWindow";
        public const string SystemAppName = "fabric:/System";
        public const string MonitorResourceGovernanceLimitsParameter = "MonitorResourceGovernanceLimits";

        // AzureStorageUploadObserver
        public const string AzureStorageUploadObserverName = "AzureStorageUploadObserver";
        public const string AzureStorageConnectionStringParameter = "AzureStorageConnectionString";
        public const string AzureBlobContainerNameParameter = "BlobContainerName";
        public const string AzureStorageAccountNameParameter = "AzureStorageAccountName";
        public const string AzureStorageAccountKeyParameter = "AzureStorageAccountKey";
        public const string ZipFileCompressionLevelParameter = "ZipFileCompressionLevel";

        // Certificate Observer
        public const string CertificateObserverName = "CertificateObserver";
        public const string CertificateObserverDaysUntilClusterExpiryWarningThreshold = "DaysUntilClusterExpiryWarningThreshold";
        public const string CertificateObserverDaysUntilAppExpiryWarningThreshold = "DaysUntilAppExpiryWarningThreshold";
        public const string CertificateObserverAppCertificateThumbprints = "AppCertThumbprintsToObserve";
        public const string CertificateObserverAppCertificateCommonNames = "AppCertCommonNamesToObserve";

        // ContainerObserver
        public const string ContainerObserverName = "ContainerObserver";

        // DiskObserver.
        public const string DiskObserverName = "DiskObserver";
        public const string DiskObserverIntervalParameterName = "RunInterval";
        public const string DiskObserverDiskSpacePercentError = "DiskSpacePercentUsageErrorThreshold";
        public const string DiskObserverDiskSpacePercentWarning = "DiskSpacePercentUsageWarningThreshold";
        public const string DiskObserverAverageQueueLengthError = "AverageQueueLengthErrorThreshold";
        public const string DiskObserverAverageQueueLengthWarning = "AverageQueueLengthWarningThreshold";
        public const string DiskObserverEnableFolderSizeMonitoring = "EnableFolderSizeMonitoring";
        public const string DiskObserverFolderPathsErrorThresholdsMb = "FolderPathsErrorThresholdsMb";
        public const string DiskObserverFolderPathsWarningThresholdsMb = "FolderPathsWarningThresholdsMb";

        // FabricSystemObserver.
        public const string FabricSystemObserverName = "FabricSystemObserver";
        public const string FabricSystemObserverConfigurationName = "FabricSystemObserverConfiguration";
        public const string FabricSystemObserverCpuErrorLimitPct = "CpuErrorLimitPercent";
        public const string FabricSystemObserverCpuWarningLimitPct = "CpuWarningLimitPercent";
        public const string FabricSystemObserverMemoryErrorLimitMb = "MemoryErrorLimitMb";
        public const string FabricSystemObserverMemoryWarningLimitMb = "MemoryWarningLimitMb";
        public const string FabricSystemObserverMemoryUsePercentError = "MemoryErrorLimitPercent";
        public const string FabricSystemObserverMemoryUsePercentWarning = "MemoryWarningLimitPercent";
        public const string FabricSystemObserverNetworkErrorActivePorts = "NetworkErrorActivePorts";
        public const string FabricSystemObserverNetworkWarningActivePorts = "NetworkWarningActivePorts";
        public const string FabricSystemObserverNetworkErrorEphemeralPorts = "NetworkErrorEphemeralPorts";
        public const string FabricSystemObserverNetworkWarningEphemeralPorts = "NetworkWarningEphemeralPorts";
        public const string FabricSystemObserverMonitorWindowsEventLog = "MonitorWindowsEventLog";
        public const string FabricSystemObserverErrorHandles = "AllocatedHandlesErrorLimit";
        public const string FabricSystemObserverWarningHandles = "AllocatedHandlesWarningLimit";
        public const string FabricSystemObserverWarningThreadCount = "ThreadCountWarningLimit";
        public const string FabricSystemObserverErrorThreadCount = "ThreadCountErrorLimit";

        // NetworkObserver.
        public const string NetworkObserverName = "NetworkObserver";
        public const string NetworkObserverConfigurationSectionName = "NetworkObserverConfiguration";

        // NodeObserver.
        public const string NodeObserverName = "NodeObserver";
        public const string NodeObserverCpuErrorLimitPct = "CpuErrorLimitPercent";
        public const string NodeObserverCpuWarningLimitPct = "CpuWarningLimitPercent";
        public const string NodeObserverMemoryErrorLimitMb = "MemoryErrorLimitMb";
        public const string NodeObserverMemoryWarningLimitMb = "MemoryWarningLimitMb";
        public const string NodeObserverMemoryUsePercentError = "MemoryErrorLimitPercent";
        public const string NodeObserverMemoryUsePercentWarning = "MemoryWarningLimitPercent";
        public const string NodeObserverNetworkErrorActivePorts = "NetworkErrorActivePorts";
        public const string NodeObserverNetworkWarningActivePorts = "NetworkWarningActivePorts";
        public const string NodeObserverNetworkErrorEphemeralPorts = "NetworkErrorEphemeralPorts";
        public const string NodeObserverNetworkWarningEphemeralPorts = "NetworkWarningEphemeralPorts";
        public const string NodeObserverNetworkErrorEphemeralPortsPercentage = "NetworkErrorEphemeralPortsPercentage";
        public const string NodeObserverNetworkWarningEphemeralPortsPercentage = "NetworkWarningEphemeralPortsPercentage";
        public const string NodeObserverNetworkErrorFirewallRules = "NetworkErrorFirewallRules";
        public const string NodeObserverNetworkWarningFirewallRules = "NetworkWarningFirewallRules";
        public const string NodeObserverEnableNodeSnapshot = "EnableNodeSnapshot";

        // For use by Linux File Descriptors monitor.
        public const string NodeObserverLinuxFileHandlesErrorLimitPct = "LinuxFileHandlesErrorLimitPercent";
        public const string NodeObserverLinuxFileHandlesWarningLimitPct = "LinuxFileHandlesWarningLimitPercent";
        public const string NodeObserverLinuxFileHandlesErrorTotalAllocated = "LinuxFileHandlesErrorLimitTotal";
        public const string NodeObserverLinuxFileHandlesWarningTotalAllocated = "LinuxFileHandlesWarningLimitTotal";

        // OSObserver.
        public const string OSObserverName = "OSObserver";
        public const string EnableWindowsAutoUpdateCheck = "EnableWindowsAutoUpdateCheck";

        // Telemetry Settings Parameters.
        public const string AiKey = "AppInsightsInstrumentationKey";
        public const string AppInsightsConnectionString = "AppInsightsConnectionString";
        public const string TelemetryProviderEnabled = "EnableTelemetryProvider";
        public const string TelemetryProviderType = "TelemetryProvider";
        public const string EmitRawMetricTelemetry = "EmitRawMetricTelemetry";
        public const string LogAnalyticsLogTypeParameter = "LogAnalyticsLogType";
        public const string LogAnalyticsSharedKeyParameter = "LogAnalyticsSharedKey";
        public const string LogAnalyticsWorkspaceIdParameter = "LogAnalyticsWorkspaceId";
        public const string InfrastructureServiceType = "InfrastructureServiceType";
        public const string ClusterTypeSfrp = "SFRP";
        public const string Undefined = "Undefined";
        public const string ClusterTypePaasV1 = "PaasV1";
        public const string ClusterTypeStandalone = "Standalone";

        // RG
        public const string PoliciesNodeName = "Policies";
        public const string RGMemoryInMB = "MemoryInMB";
        public const string RGMemoryInMBLimit = "MemoryInMBLimit";
        public const string RGCpuCores = "CpuCores";
        public const string RGCpuCoresLimit = "CpuCoresLimit";
        public const string RGCpuShares = "CpuShares";
        public const string RGPolicyNodeName = "ResourceGovernancePolicy";
        public const string RGPolicyNodeTypeName = "ResourceGovernancePolicyType";
        public const string RGSvcPkgPolicyNodeName = "ServicePackageResourceGovernancePolicy";
        public const string RGSvcPkgPolicyNodeTypeName = "ServicePackageResourceGovernancePolicyType";
        public const string CodePackageRef = "CodePackageRef";
        public const string ServiceManifestImport = "ServiceManifestImport";
        public const string ServiceManifestName = "ServiceManifestName";
        public const string ServiceManifestRef = "ServiceManifestRef";
        public const string DefaultValue = "DefaultValue";
        public const string Parameter = "Parameter";
        public const string Parameters = "Parameters";

        // AppManifest Thresholds
        public const string AppManifestMemoryWarningLimitMb = "FabricObserver_MemoryWarningLimitMb";
        public const string AppManifestMemoryErrorLimitMb = "FabricObserver_MemoryErrorLimitMb";
        public const string AppManifestMemoryWarningLimitPercent = "FabricObserver_MemoryWarningLimitPercent";
        public const string AppManifestMemoryErrorLimitPercent = "FabricObserver_MemoryErrorLimitPercent";
        public const string AppManifestCpuErrorLimitPercent = "FabricObserver_CpuErrorLimitPercent";
        public const string AppManifestCpuWarningLimitPercent = "FabricObserver_CpuWarningLimitPercent";
        public const string AppManifestNetworkErrorActivePorts = "FabricObserver_NetworkErrorActivePorts";
        public const string AppManifestNetworkWarningActivePorts = "FabricObserver_NetworkWarningActivePorts";
        public const string AppManifestNetworkErrorEphemeralPorts = "FabricObserver_NetworkErrorEphemeralPorts";
        public const string AppManifestNetworkWarningEphemeralPorts = "FabricObserver_NetworkWarningEphemeralPorts";
        public const string AppManifestNetworkErrorEphemeralPortsPercent = "FabricObserver_NetworkErrorEphemeralPortsPercent";
        public const string AppManifestNetworkWarningEphemeralPortsPercent = "FabricObserver_NetworkWarningEphemeralPortsPercent";
        public const string AppManifestDumpProcessOnError = "FabricObserver_DumpProcessOnError";
        public const string AppManifestDumpProcessOnWarning = "FabricObserver_DumpProcessOnWarning";
        public const string AppManifestErrorOpenFileHandles = "FabricObserver_ErrorOpenFileHandles";
        public const string AppManifestWarningOpenFileHandles = "FabricObserver_WarningOpenFileHandles";
        public const string AppManifestErrorHandleCount = "FabricObserver_ErrorHandleCount";
        public const string AppManifestWarningHandleCount = "FabricObserver_WarningHandleCount";
        public const string AppManifestErrorThreadCount = "FabricObserver_ErrorThreadCount";
        public const string AppManifestWarningThreadCount = "FabricObserver_WarningThreadCount";
        public const string AppManifestWarningPrivateBytesMb = "FabricObserver_WarningPrivateBytesMb";
        public const string AppManifestErrorPrivateBytesMb = "FabricObserver_ErrorPrivateBytesMb";
        public const string AppManifestWarningPrivateBytesPercent = "FabricObserver_WarningPrivateBytesPercent";
        public const string AppManifestErrorPrivateBytesPercent = "FabricObserver_ErrorPrivateBytesPercent";
        public const string AppManifestWarningRGMemoryLimitPercent = "FabricObserver_WarningRGMemoryLimitPercent";
        public const string AppManifestWarningRGCpuLimitPercent = "FabricObserver_WarningRGCpuLimitPercent";
    }
}
