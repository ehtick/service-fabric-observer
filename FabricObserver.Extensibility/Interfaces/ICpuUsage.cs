﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using Microsoft.Win32.SafeHandles;

namespace FabricObserver.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICpuUsage
    {
        /// <summary>
        /// Gets the current CPU usage for the supplied process identifier.
        /// </summary>
        /// <param name="procId">Process identifier.</param>
        /// <param name="procName">Optional: Process name.</param>
        /// <returns>Percentage of usage across all cores.</returns>
        double GetCurrentCpuUsagePercentage(int procId, string procName = null, SafeProcessHandle procHandle = null);
    }
}