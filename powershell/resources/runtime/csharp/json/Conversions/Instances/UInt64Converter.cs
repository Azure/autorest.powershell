/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Carbon.Json.Converters
{
    internal sealed class UInt64Converter : JsonConverter<ulong>
    {
        public override JsonNode ToJson(ulong value) => new JsonNumber(value.ToString());

        public override ulong FromJson(JsonNode node) => (ulong)node;
    }
}