﻿//
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License. See License.txt in the project root for license information.
//
// This file contain internal APIs that are subject to change without notice.
// Use at your own risk.
//

namespace Microsoft.VisualStudio.Text.Utilities
{
    /// <summary>
    /// Allows code in VS-Platform to use complex telemetry properties, which reduce boilerplate code.
    /// </summary>
    public class TelemetryComplexProperty
    {
        public object Property { get; }

        public TelemetryComplexProperty(object property)
        {
            Property = property;
        }
    }
}
