﻿//
// Copyright (c) Vogler Engineering GmbH. All rights reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.
//
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SmartDevicesGateway.Model.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        Created,
        Started,
        InProgress,
        Done,
        Closed
    }
}
