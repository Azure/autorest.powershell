/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;

namespace Carbon.Json.Converters
{
    internal sealed class GuidConverter : JsonConverter<Guid>
    {
        public override JsonNode ToJson(Guid value) => new JsonString(value.ToString());

        public override Guid FromJson(JsonNode node) => (Guid)node;
    }
}